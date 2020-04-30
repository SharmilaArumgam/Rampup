using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mvc_CoreApplication.Models;
using Microsoft.AspNetCore.Http;

namespace Mvc_CoreApplication.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {

            CookieOptions cookieOptions = new CookieOptions();// for adding features like expires.domain and path so on.
            cookieOptions.Expires = new DateTimeOffset(DateTime.Now.AddDays(7)); //To make the cookie expire in 7 days.
            if (!HttpContext.Request.Cookies.ContainsKey("first_request"))
            {
                HttpContext.Response.Cookies.Append("first_request", DateTime.Now.ToString(), cookieOptions);
                return Content("Welcome, new visitor!");
            }
    else
            {
                DateTime firstRequest = DateTime.Parse(HttpContext.Request.Cookies["first_request"]);
                return Content("Welcome back, user! You first visited us on: " + firstRequest.ToString());
            }
        }

        [HttpGet]
        public IActionResult SimpleBinding()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SimpleBinding(Customer customer)
        {
            //TODO: Update in DB here...
            if (ModelState.IsValid)
                return Content("User has been added to the Database");
            else
                return View(customer);
        }
    }
}