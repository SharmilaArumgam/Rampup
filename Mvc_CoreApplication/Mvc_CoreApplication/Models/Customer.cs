using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc_CoreApplication.Models
{
	public class Customer 
    {
        [WebUserBirthdayValidationAttribute]
        public DateTime Birthday { get; set; }
    }
}
