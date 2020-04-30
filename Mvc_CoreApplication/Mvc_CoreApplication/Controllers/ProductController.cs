using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mvc_CoreApplication.Models;

namespace Mvc_CoreApplication.Controllers
{
    public class ProductController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            string s = null;
            return Content(s.Trim());
        }

        [HttpPost]
        [Route("Product/Create", Name = "Update")]
        public IActionResult Create(Product webUser)
        {
            if (ModelState.IsValid)
            {
                // Here the WebUser should be saved. Afterwards we would normally return another View, to 
                // indicate that the User has been successfully created, or redirect to another page 
            }
            return View("~/Views/Customer/SimpleBinding.cshtml");
                
        }
    }
}