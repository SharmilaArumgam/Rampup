using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mvc_CoreApplication.Models;
namespace Mvc_CoreApplication.ViewModels
{
    public class Source
    {
        public WebUser User { get; set; }

        public List<string> Countries { get; set; }
    }
}
