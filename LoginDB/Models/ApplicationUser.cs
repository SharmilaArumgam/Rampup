using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginDB.Models
{
    public class ApplicationUser : IdentityUser
    {
        public override string UserName { get; set; }
        public override string Email { get; set; }

       // public override string PasswordHash { get => base.PasswordHash; set => base.PasswordHash = value; }

    }
}
