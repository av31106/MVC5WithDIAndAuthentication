using MVC5WithDIAndAuthontication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5WithDIAndAuthontication.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepository _EmployeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _EmployeeRepository = employeeRepository;
        }

        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.TotalEmployeeCount = _EmployeeRepository.GetAll().Count;
            return View();
        }

        [HttpPost]
        [ActionName("Index")]
        public ActionResult Index1()
        {
            _EmployeeRepository.Add(new EmployeeModel() { Code = "XXXX", Name = "XXXXX" });
            ViewBag.TotalEmployeeCount = _EmployeeRepository.GetAll().Count;
            return View();
        }

        [HttpGet]
        public ActionResult List()
        {
            
            return View(_EmployeeRepository.GetAll());
        }
    }
    
}