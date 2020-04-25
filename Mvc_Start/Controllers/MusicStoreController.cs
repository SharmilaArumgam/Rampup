using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Start.Controllers
{
    public class MusicStoreController : Controller
    {
        // GET: MusicStore
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
        
        public string Welcome()
        {
            return "Hello, this is welcome action message";
        }

        public string ShowMusic(string MusicTitle)
        {
            return "Sharmila selected " + MusicTitle + " Music";
        }
    }
}