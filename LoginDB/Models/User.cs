using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LoginDB.Models
{
    public class User 
    {
        [Required]
        [EmailAddress]
        [Key]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public  string Password { get; set; }
    }
}
