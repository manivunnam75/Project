using Microsoft.AspNetCore.Mvc;
using TrainnePortal.Migrations;
using TrainnePortal.Models.Admin;
using TrainnePortal.Models.Services;
using TrainnePortal.Models.User;
namespace TrainnePortal.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _database;
        private readonly Icrud _crud;


        public HomeController(DataContext dataContext, Icrud crud)
        {
            _database = dataContext;
            _crud = crud;
        }
        Credentials c = new Credentials();
        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registration(Registration registration,OverView o1)
        {
            o1.Name = registration.firstName;
            _database.OverView.Add(o1);
            var details = _crud.AddTrainee(registration);
            return View();
        }

        [HttpGet]
        public IActionResult UserLogin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UserLogin(LoginModel l1)
        {
            var c3 = c.Details(l1);
            if (c3.UserName == l1.UserName && c3.Password == l1.Password)
            {
                return RedirectToAction("Admin");
            }
            return View();
        }
        public IActionResult Admin()
        {

            return View();
        }
        [HttpGet]
        public IActionResult Batch()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Batch(BatchModel b1)
        {
      
            TempData["btname"] = b1.batchName;
            TempData["btId"] = b1.batchId;
            
         
            return RedirectToAction("Allrecords");
        }
        [HttpGet]
        public IActionResult Allrecords()
        {
            var records = _database.TrainneDetails.ToList();
            return View(records);

        }
        [HttpPost]
        public IActionResult Allrecords(List<Registration> model, BatchModel b1,Models.User.BatchList b2,OverView o1)
        {
            string name = "";
            int batchid = 0;
            string course = "";
            if (TempData.ContainsKey("btname"))
            {
                name = TempData["btname"].ToString();
                b2.Batchname = name;
            }
            if (TempData.ContainsKey("btId"))
            {
                batchid = (int)TempData["btId"];
                b2.BatchId= batchid;
            }
            
         
            List<Registration> m1 = new List<Registration>();
             m1 = model.FindAll(x => x.IsChecked == true);
            if (m1 != null)
            {
               
                for (int i = 0; i < m1.Count; i++)
                {
                    var m = new BatchModel();
                    var m3 = new OverView();
                    m3 = _database.OverView.FirstOrDefault(x => x.Name == m1[i].firstName);
                    m.EmpId = m1[i].EmployeId;
                    m.firstName = m1[i].firstName;
                    m.lastName = m1[i].lastname;
                    m.batchName = name;
                    m.batchId = batchid;               
                    m3.EmpId = m.EmpId;
 
                    _database.BatchDetails.Add(m);
                    _database.SaveChanges();
                    _database.OverView.Update(m3);
                    _database.SaveChanges();
                   
  
                }
                _database.BatchList.Add(b2);
                _database.SaveChanges();    

            }
                return RedirectToAction("UpdateBatch");
        }
        [HttpGet]
        public IActionResult BatchRecords()
        {
            var batchrec = _database.BatchDetails.ToList();
          
            return View(batchrec);
        }
        public IActionResult Delete(int id) 
        {
            var d = _database.SubBatche.FirstOrDefault(x => x.BacthId == id); 
            if (d != null) 
            {
                _database.SubBatche.Remove(d); _database.SaveChanges();
           
            }
            return RedirectToAction("ViewSubbatch");
        }
        [HttpGet]
        public IActionResult UpdateBatch()
        {
            var btc = _database.BatchList.ToList();
            ViewBag.subbbatch = _database.SubBatche.ToList();
            return View(btc);
        }
        [HttpGet]
        public IActionResult ViewBatch(int id)
        {
            
                var b = _database.BatchDetails.Where(x=>x.batchId==id).ToList();
            return View(b);
              
        }
       
        [HttpGet]
        public IActionResult OverView()
        {
            var over=_database.OverView.ToList();   
            return View(over);
        }

        [HttpGet]
       public IActionResult GetPop(int id)
        {
            var data = _database.TrainneDetails.FirstOrDefault(i => i.EmployeId == id);
            return PartialView(data);
        }
       
        [HttpGet]
        public IActionResult CreateSubBatch(int id)
        {
            TempData["batchid"] = id;
            return View();
        }
        [HttpPost]
        public IActionResult CreateSubBatch(SubBatch s1)
        {
       
           
            TempData["sbtname"] = s1.BatchName;
            TempData["course"] = s1.Course;


            return RedirectToAction("SubBatch");
            
        }

        [HttpGet]
        public IActionResult SubBatch()
        {
            int id = 0;
            if (TempData.ContainsKey("sbtname"))
            {
              id = (int)TempData["batchid"];
            }
            var batchrec = _database.BatchDetails.Where(x => x.batchId == id).ToList();

            return View(batchrec);
        }
        [HttpPost]
        public IActionResult SubBatch(List<BatchModel>s1,SubBatch s2,overview m1)
        {
            string sbname = "";
            string course = "";
            if(TempData.ContainsKey("sbtname"))
            {
                sbname = TempData["sbtname"].ToString();
            }
            if (TempData.ContainsKey("course"))
            {
                course = TempData["course"].ToString();
            }
            
          
            var selected = s1.FindAll(x => x.Istick == true);
            var m3 = new OverView();
            if(selected != null) {
                for (int i = 0; i < selected.Count; i++)
                {
                    m3 = _database.OverView.FirstOrDefault(x => x.Name == selected[i].firstName);
                    s2.FullName = selected[i].firstName + "." + selected[i].lastName;
                    s2.BacthId = selected[i].batchId;
                    s2.BatchName = sbname;
                    s2.Course = course;
                    s2.EmpId = selected[i].EmpId;
                    
                    if (m3.Name == selected[i].firstName && m3.Course1 == "NA")
                    {
                        m3.Course1 = course;

                    }
                    else if (m3.Name == selected[i].firstName && m3.Course2 == "NA")
                    {
                        m3.Course2 = course;
                    }
                    else if (m3.Name == selected[i].firstName && m3.Course2 == "NA")
                    {
                        m3.Course3 = course;
                    }
                }
            }
            _database.SubBatche.Add(s2);
            _database.SaveChanges();
            _database.OverView.Update(m3);
            _database.SaveChanges();
            return RedirectToAction("UpdateBatch");
        }
        public IActionResult ViewSubbatch(string id)
        {
            var subrec = _database.SubBatche.Where(x=>x.BatchName==id).ToList();
            return View(subrec);
        }
      
      
    
    }
    

}
