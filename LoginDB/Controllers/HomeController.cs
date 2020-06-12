using Grpc.Core;
using LoginDB.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json.Serialization;
//using System.Web.Mvc;

namespace LoginDB.Controllers
{
    // [Route("Home/Register")]
    public class HomeController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        public HomeController(UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        
        public PartialViewResult GetBody()
        {
            return PartialView("_body");
        }

        public IActionResult Xml()
        {
            return View();//for getting xml data from api.
        }

        public JsonResult JsonData()
        {
            List<PersonalDetails> details = new List<PersonalDetails>();
            details.Add(new PersonalDetails()
            {
                ID = 1,
                NewsTitle = "Title1",
                Body = "Admin News"
            });
            details.Add(new PersonalDetails()
            {
                ID = 2,
                NewsTitle = "Title2",
                Body = "Moderator News"
            });
            details.Add(new PersonalDetails()
            {
                ID = 3,
                NewsTitle = "Title3",
                Body = "User News"
            });

            //var json = Newtonsoft.Json.JsonConvert.SerializeObject(details);
            //return Json(json, System.Web.Mvc.JsonRequestBehavior.AllowGet);
            return Json(details);
            //return Json(new { Name = "Sharmila Arumugam", ID = 1 });
            //return Ok(details);
        }

        //[HttpPost]
        //public ContentResult AjaxMethod()
        //{
        //    string xml = System.IO.File.ReadAllText(HttpContext.Current.Server.MapPath("~/XML/Customers.xml"));
        //    return Content(xml);
        //}

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Page", "Home");
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Page()
        {
            return View();
        }

        public IActionResult HtmlHelper()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

        public IActionResult CreateDetails()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(User model)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = model.Email, Email = model.Email };
                var result = await userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("login", "home");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Login(string returnUrl)
        {
            Login model = new Login
            {
                ReturnUrl = returnUrl,
                ExternalLogins = (await signInManager.GetExternalAuthenticationSchemesAsync()).ToList()
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Login(Login model)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(model.Email, model.Password,
                                                       model.RememberMe, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("page", "home");
                }

                    ModelState.AddModelError(string.Empty,"Invalid Login Attempt");
            }
            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult ExternalLogin(string provider, string returnUrl)
        {
            var redirectUrl = Url.Action("ExternalLoginCallback", "Home", new { ReturnUrl = returnUrl });
            var properties = signInManager.ConfigureExternalAuthenticationProperties(provider, redirectUrl);
            return new ChallengeResult(provider, properties);
        }

        [AllowAnonymous]
        public async Task<IActionResult> ExternalLoginCallback(string returnUrl = null, string remoteError = null)
        { 
            returnUrl = returnUrl ?? Url.Content("~/home/page");

              Login loginViewModel = new Login
            {
                ReturnUrl = returnUrl,
                ExternalLogins = (await signInManager.GetExternalAuthenticationSchemesAsync()).ToList()
            };

            if (remoteError != null)
            {
                ModelState.AddModelError(string.Empty, $"Error from external provider: {remoteError}");
                return View("Login", loginViewModel);
            }

            var info = await signInManager.GetExternalLoginInfoAsync();
            if (info == null)
            {
                ModelState.AddModelError(string.Empty, "Error loading external login information");
                return View("Login", loginViewModel);
            }

            var signInResult = await signInManager.ExternalLoginSignInAsync(info.LoginProvider,
                info.ProviderKey, isPersistent: false, bypassTwoFactor: true);

            if (signInResult.Succeeded)
            {
                return LocalRedirect(returnUrl);
            }
            //else
            //{
            //    var email = info.Principal.FindFirstValue(ClaimTypes.Email);
            //    if (email != null)
            //    {
            //        var user = await userManager.FindByEmailAsync(email);
            //        if (user == null)
            //        {
            //            user = new ApplicationUser
            //            {
            //                UserName = info.Principal.FindFirstValue(ClaimTypes.Email),
            //                Email = info.Principal.FindFirstValue(ClaimTypes.Email)
            //            };
            //            await userManager.CreateAsync(user);
            //        }
            //        await userManager.AddLoginAsync(user, info);
            //        await signInManager.SignInAsync(user, isPersistent: false);
            //        return LocalRedirect(returnUrl);
            //    }
            //    ViewBag.ErrorTitle = $"Email claim not recieved from:{info.LoginProvider}";
            //    ViewBag.ErrorMessage = "Please contact support in asharmi98@gmail.com";
            //}
            return View("Error");
        }

    }
}