using DemoApplication.Models.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Security.Cryptography.X509Certificates;

namespace DemoApplication.Controllers
{
    public class HomeController : Controller
    {
        public readonly EmployeeDbContext _employeeDbContext;

        public HomeController(EmployeeDbContext employeeDbContext)
        {
            _employeeDbContext = employeeDbContext;
        }

        [HttpGet]

        public IActionResult Index()
        {
            var details = _employeeDbContext.Employees.ToList();
            return View(details);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Employe emp)
        {
            if (ModelState.IsValid)
            {
                var employe = new Employe()
                {

                    Name = emp.Name,
                    Address = emp.Address,
                    Company = emp.Company,
                    Designation = emp.Designation

                };
                _employeeDbContext.Add(employe);
                _employeeDbContext.SaveChanges();
                return RedirectToAction("Add");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult Update(int Id)
        {
            var emp = _employeeDbContext.Employees.FirstOrDefault(x => x.EmployeId == Id);
            return View(emp);
        }
        [HttpPost]
        public IActionResult Update(Employe employe)
        {
            var emp = _employeeDbContext.Employees.FirstOrDefault(e => e.EmployeId == employe.EmployeId);

            if (emp != null)

            {

                emp.Name = employe.Name;
                emp.Address = employe.Address;
                emp.Company = employe.Company;
                emp.Designation = employe.Designation;


                _employeeDbContext.Update(emp);
                _employeeDbContext.SaveChanges();
            }
            return RedirectToAction("Index");


        }
        [HttpGet]
        public IActionResult Fetch()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Details(Employe data)
        {
            int id = data.EmployeId;
            ViewBag.details = _employeeDbContext.Employees.FirstOrDefault(m => m.EmployeId == id);
            if (ViewBag.details == null)
            {
                ViewBag.Error = "Invalid data";
                return View();
            }
            else
            {
                return View(ViewBag.details);
            }


        }
        [HttpGet]
        public IActionResult Delete(int id)
        { 
         
            var del = _employeeDbContext.Employees.FirstOrDefault(n => n.EmployeId == id);
            _employeeDbContext.Employees.Remove(del);   
            _employeeDbContext.SaveChanges();   
            return RedirectToAction("Index");  
        }
       















        




    }
}