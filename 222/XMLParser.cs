using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _222.EF;
using System.Xml;
using System.Xml.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace _222
{
    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
    public class XMLParser
    {

        private string path;

        public XMLParser(string path)
        {
            this.path = path;
        }

        public XMLParser() { }

        public List<Employee> XmlPaserMethodAsync()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(path);

            XmlNodeList nodes = doc.DocumentElement.SelectNodes("/employees/employee");

            List<Employee> employees = new List<Employee>();
            foreach (XmlNode node in nodes)
            {
                Employee employee = new Employee();

                employee.Name = node.SelectSingleNode("name").InnerText;
                employee.Surname = node.SelectSingleNode("surname").InnerText;
                employee.About = node.SelectSingleNode("about").InnerText;
                employee.ImageLocation = node.SelectSingleNode("image").InnerText;
                employee.BirthDate = Convert.ToDateTime(node.SelectSingleNode("birthDate").InnerText);
                employees.Add(employee);
            }
            return employees;
        }
        public static void ToXmlParser(List<Employee> employeeList)
        {
            XElement employees = new XElement("employees");
            XDocument xmlDocument = new XDocument();
            foreach (Employee employee in employeeList)
            {
                XElement employeeElem = new XElement("employee");
                XElement employeeElemName = new XElement("name", employee.Name);
                XElement employeeElemSurname = new XElement("surname", employee.Surname);
                XElement employeeElemAbout = new XElement("about", employee.About);
                XElement employeeElemPhoto = new XElement("image", employee.ImageLocation);
                XElement employeeElemDate = new XElement("birthDate", employee.BirthDate);
                employeeElem.Add(employeeElemName);
                employeeElem.Add(employeeElemSurname);
                employeeElem.Add(employeeElemAbout);
                employeeElem.Add(employeeElemPhoto);
                employeeElem.Add(employeeElemDate);
          
                employees.Add(employeeElem);
            }

            xmlDocument.Add(employees);
            xmlDocument.Save("employees.xml");
        }
    }
}
