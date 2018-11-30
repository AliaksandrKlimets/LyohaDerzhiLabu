using _222.EF;
using _222.Models;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Http;

namespace _222.Services
{
    public class EmployeeService
    {
        Context _context;
        IHostingEnvironment _environment;

        public EmployeeService(Context context, IHostingEnvironment env)
        {
            _environment = env;
            _context = context;
        }

        public IEnumerable<Employee> GetAll(string name, string sort)
        
        {
            IQueryable<Employee> employees = _context.Employees;

            if (!string.IsNullOrEmpty(name)) {
                employees = employees.Where(p => p.Name.Contains(name));
            }

            if (!string.IsNullOrEmpty(sort)) {
                switch (sort) {
                    case "ASC":
                        employees = employees.OrderBy(p => p.Name);
                        break;
                    case "DESC":
                        employees = employees.OrderByDescending(p => p.Name);
                        break;
                    default:
                        employees = employees.OrderBy(p => p.Name);
                        break;
                }
            }
            return employees;
        }

        public void Create(CreateModel model)
        {
            Employee employee = new Employee {
                Name = model.Name,
                Surname = model.Surname,
                About = model.About,
                BirthDate = model.BirthDate
            };
            if (model.Image != null)
            {
               
                string str = GetHashString(model.Image.FileName);
                string path = @"\images\" + str +".jpg";
                string absolutePath = _environment.WebRootPath + path;
                using (var fileStream = new FileStream(absolutePath, FileMode.Create))
                {
                    model.Image.CopyTo(fileStream);
                }
                employee.ImageLocation = path;
            }
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public Employee Get(int id)
        {
            return _context.Employees.Find(id);

        }

        public void Edit(EditModel model)
        {
            
            Employee employee = _context.Employees.Find(model.Id);
            employee.Name = model.Name;
            employee.Surname = model.Surname;
            employee.About = model.About;
          
          
            if (model.Image != null)
            {
                
                string str = GetHashString(model.Image.FileName);
                string path = @"\images\" + str + ".jpg";
                string absolutePath = _environment.WebRootPath + path;
                using (var fileStream = new FileStream(absolutePath, FileMode.Create))
                {
                    model.Image.CopyTo(fileStream);
                }
                employee.ImageLocation = path;
            }
            _context.Entry(employee).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var empl = _context.Employees.Find(id);
            if (empl.ImageLocation != null)
            {
                string absolutePath = _environment.WebRootPath + empl.ImageLocation;
                File.Delete(absolutePath);
            }
            _context.Employees.Remove(empl);
            _context.SaveChanges();
        }
        private  string GetHashString(string s)
        {
            byte[] bytes = System.Text.Encoding.ASCII.GetBytes(s);
            MD5CryptoServiceProvider CSP = new MD5CryptoServiceProvider();
            byte[] byteHash = CSP.ComputeHash(bytes);
            string hash = string.Empty;
            foreach (byte b in byteHash)
                hash += string.Format("{0:x2}", b);
            return hash;
        }

        public  void Parse(IFormFile file) {
            var path = file.FileName;
            XMLParser parser = new XMLParser(path);
            List<Employee> employees = parser.XmlPaserMethodAsync();
          
            foreach (Employee employee in employees) {
                _context.Add(employee);
            }
              _context.SaveChangesAsync();

        }

        public async void ParseToXml() {
            var employees =await _context.Employees.ToListAsync();
            XMLParser.ToXmlParser(employees);
        }
    }
}


