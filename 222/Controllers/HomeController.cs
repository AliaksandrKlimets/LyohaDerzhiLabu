using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _222.Models;
using _222.EF;
using _222.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;

namespace _222.Controllers
{
    [Authorize(AuthenticationSchemes =CookieAuthenticationDefaults.AuthenticationScheme)]
    public class HomeController : Controller
    {
       
        EmployeeService _employeeService;

        public HomeController(EmployeeService service)
        {
            _employeeService = service;
        }

        public IActionResult Index(string name, string sort)
        {
            return View(_employeeService.GetAll(name, sort));
        }


        [HttpPost]
        public IActionResult Create(CreateModel model)
        {
            if (ModelState.IsValid)
            {
                _employeeService.Create(model);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public JsonResult GetInfo(int id)
        {
            return Json(_employeeService.Get(id));
        }

        [HttpPost]
        public IActionResult Edit(EditModel model)
        {
            if (ModelState.IsValid)
            {
                _employeeService.Edit(model);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _employeeService.Delete(id);
            return RedirectToAction("Index");
        }
        
        public IActionResult ParseXML(IFormFile doc) {
            _employeeService.Parse(doc);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult ParseToXml() {
            _employeeService.ParseToXml();
            return RedirectToAction("Index");
        }  
    }
}
