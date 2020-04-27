using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc_Start.Models
{
    public class ClassicalMusic
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public string GetDateTime()
        {
            return DateTime.Now.ToString();
        }
    }
}