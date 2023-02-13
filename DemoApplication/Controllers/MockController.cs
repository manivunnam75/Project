using DemoApplication.Models.Context;
using Microsoft.AspNetCore.Mvc;

namespace DemoApplication.Controllers
{
    public class MockController : Controller
    {
        private readonly Mock _mock;
        public MockController(Mock mock) 
        {
            _mock= mock;    
        } 
        public IActionResult Print() 
        {
            var details = _mock.ToList();
            return View(); 
        } 
        public IActionResult Index(Mock detail)

        {

            List<Mock> list = new List<Mock>();
            var emp = new Mock()
            {
                Name= detail.Name,  
                EmployeId=detail.EmployeId,
                Address=detail.Address,
                Designation=detail.Designation, 
                Company=detail.Company

            };
            list.Add(emp);
            return View(emp);
              
        }
    }
}
