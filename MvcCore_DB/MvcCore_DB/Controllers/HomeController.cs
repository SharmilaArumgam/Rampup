using Microsoft.AspNetCore.Mvc;

using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using MvcCore_DB.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
namespace MvcCore_DB.Controllers
{
    public class HomeController : Controller
    {
        //private readonly IConfiguration configuration;

        //public HomeController(IConfiguration config)
        //{
        //    this.configuration = config;
        //}
        //public IActionResult Index()
        //{
        //    string connectionstring = configuration.GetConnectionString("DefaultConnectionString");
        //    SqlConnection connection = new SqlConnection(connectionstring);
        //    connection.Open();
        //    SqlCommand com = new SqlCommand("SELECT Count(*) FROM [user]", connection);
        //    var count = (int)com.ExecuteScalar();
        //    ViewData["TotalData"] = count;
        //    connection.Close();
        //    return View();
        //}
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
       public HomeController(UserManager<IdentityUser> um,
           SignInManager<IdentityUser> sm)
        {
            this.userManager = um;
            this.signInManager = sm;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(Home model)
        {
            if(ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = model.Email };
                var result = await userManager.CreateAsync(user, model.Password);

                if(result.Succeeded)
                {
                    await signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("index","home");
                }
            }
            return View(model);
        }
    }
}