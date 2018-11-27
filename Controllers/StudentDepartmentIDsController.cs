using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SecureStudentManager.Models;
using SecureStudentManager.ModelUtils;

namespace SecureStudentManager.Controllers
{
    public class StudentDepartmentIDsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: StudentDepartmentIDs/Create
        [HttpGet]
        public ActionResult AddStudentToDpt()
        {
            //  Guid 
            Student student = Session["StudentDetails"] as Student;
            int stId = student.StudentId;
            var encoded = SecureCodes.Encode(stId.ToString());
            //student.StudentId = Convert.ToInt32(encoded);
            ViewBag.EncodedId = encoded;

           ViewBag.CurrentStudent = student;
            ViewBag.Department = db.Departments.ToList<Department>();
            return View();
        }
        [HttpPost]
        public ActionResult AddStudentToDpt(StudentDepartmentIDs studentDepartmentIDs)
        {
            if (ModelState.IsValid)
            {             int stId = studentDepartmentIDs.StudentId;
                var decoded = SecureCodes.Decode(stId.ToString());
               studentDepartmentIDs.StudentId = Convert.ToInt32(decoded);

                db.studentDepartmentIDs.Add(studentDepartmentIDs);
                db.SaveChanges();
               return Redirect("/students/Index");
            }
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
