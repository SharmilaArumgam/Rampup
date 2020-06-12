using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoginDB.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Display(Name = "Name")]
        public string StudentName { get; set; }
        public Gender StudentGender { get; set; }
    }

    public enum Gender
    {
        Male,
        Female
    }
}
