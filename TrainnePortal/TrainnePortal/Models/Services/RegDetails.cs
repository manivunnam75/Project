
using Microsoft.AspNetCore.Hosting;
using TrainnePortal.Models.Services;
using TrainnePortal.Models.User;

namespace trainneportal.models.services
{
    public class Regdetails : Icrud
    {
        private readonly DataContext Context;
        private readonly IWebHostEnvironment webHostEnvironment; 
        public Regdetails(DataContext context, IWebHostEnvironment hostEnvironment) {
            Context = context;
            this.webHostEnvironment =hostEnvironment;
        }
        public Registration AddTrainee(Registration r1)
        {
            string filename = Upload(r1);
            Registration r2 = new Registration()
            {
                EmployeId = r1.EmployeId,
                firstName = r1.firstName,
                lastname = r1.lastname,
                father_Name = r1.father_Name,
                birthDate = r1.birthDate,
                degree = r1.degree,
                branch = r1.branch,
                college = r1.college,
                passOutYear = r1.passOutYear,
                Address = r1.Address,
                pincode = r1.pincode,
                mobile_number = r1.mobile_number,
                Gender = r1.Gender,
                pic = filename,
                Email = r1.Email,
                DOJ=r1.DOJ

            };
            Context.TrainneDetails.Add(r2);
            Context.SaveChanges();

            return r2;

        }
        private string Upload(Registration registration)
        {
            string uniqueFileName = null;

            if (registration.Image != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + registration.Image.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    registration.Image.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }

    }
}
