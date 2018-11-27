using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SecureStudentManager.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }
        [Required]
        [StringLength(30)]
        public string DepartmentName { get; set; }


    }
}