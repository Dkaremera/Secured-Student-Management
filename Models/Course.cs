using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SecureStudentManager.Models
{
    public class Course
    {
        public int CourseID { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        public string CourseName { get; set; }

        [Required]
        public int Credits { get; set; }
        public int DepartmentID { get; set; }
      

    }
}