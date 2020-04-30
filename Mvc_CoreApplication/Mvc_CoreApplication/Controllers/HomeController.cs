using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mvc_CoreApplication.Models;
using Mvc_CoreApplication.ViewModels;

namespace Mvc_CoreApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
			Source viewModel = new Source();
			viewModel.User = new WebUser()
			{
				FirstName = "Sharmila",
				LastName = "Arumugam",
				Country = "France"
			};
			viewModel.Countries = new List<string>()
	{
		"USA",
		"Canada",
		"Australia"
	};
			return View(viewModel);
		}

        public IActionResult LayoutTest()
        {
            return View();
        }

		public IActionResult Error()
		{
			return Content("We're so sorry, but an error just occurred! We'll try to get it fixed ASAP!");
		}
		[HttpGet]
		public IActionResult QueryTest()
		{
			//string name = null;
			//if (!String.IsNullOrEmpty(HttpContext.Request.Query["name"]))
			//	name = HttpContext.Request.Query["name"];

			//return Content("Name from query string: " + name);
			return View();
		}
		[HttpPost]
		public IActionResult QueryPostTest()
		{
			return Content("Hello, " + HttpContext.Request.Form["UserName"] + ". You are " + HttpContext.Request.Form["UserAge"] + " years old!");
		}
	}
}