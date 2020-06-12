using LoginDB.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Xml.Linq;

namespace LoginDB.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : Controller
    {
        List<PersonalDetails> details = new List<PersonalDetails>();

        [Route("GetAllDetails")]
        [HttpGet]
        public IEnumerable<PersonalDetails> GetAllDetails()
        {
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
            details.Add(new PersonalDetails()
            {
                ID = 4,
                NewsTitle = "Title4",
                Body = "Grantee News"
            });
            details.Add(new PersonalDetails()
            {
                ID = 5,
                NewsTitle = "Title5",
                Body = "Partner News"
            });

            return details;
        }

        [Route("PostAllDetails")]
        [HttpPost]
        public IActionResult PostAllDetails([FromBody] PersonalDetails person)
        {
            //return person.ID + person.Name + person.Email + person.PhoneNo;
            details.Add(new PersonalDetails()
            {
                ID = person.ID,
                NewsTitle = person.NewsTitle,
                Body = person.Body
            });
            return Ok();
        }

        [Route("GetData")]
        [HttpGet]
        public IEnumerable<XElement> GetData()
        {
            XElement xelement = XElement.Load("D:/Rampup/LoginDB/XML/Customer.xml");
            yield return xelement;
        }

        //Json Serailization
        [Route("GetMovies")]
        [HttpGet]
        public JsonResult Get()
        {
            return Json(_cinematicItemRepository.CinematicItems());
        }

        //Returning Complex Objects
        [HttpGet("{shortName}")]
        public CinematicItem Get(string shortName)
        {
            return _cinematicItemRepository.GetByShortName(shortName);
        }

        //XML Serialization
        [Produces("application/xml")]
        [HttpGet("{sequel}")]
        public CinematicItem Related(string sequel)
        {
            return _cinematicItemRepository.GetBySequel(sequel);
        }
    }
}