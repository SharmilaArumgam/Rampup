using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginDB.Models
{
    public static class _cinematicItemRepository
    {
        public static List<CinematicItem> CinematicItems()
        {
            return new List<CinematicItem>
           {
      new CinematicItem
      {
         Title = "Iron Man 1",
         Description = "First movie to kick off the MCU.",
         Rating = "PG-13",
         ShortName = "IM1",
         Sequel = "IM2"
      },
      new CinematicItem
      {
         Title = "The Dark Knight Rises",
         Description = "First movie to kick off the DC.",
         Rating = "PG-12",
         ShortName = "Batman",
         Sequel = "Batman Begins"
      },
   };
}
        public static CinematicItem GetByShortName(string shortName)
        {
            return CinematicItems().FirstOrDefault(ci => ci.ShortName == shortName);
        }

        public static CinematicItem GetBySequel(string sequelShortName)
        {
            return CinematicItems().FirstOrDefault(ci => ci.Sequel == sequelShortName);
        }
    }
}
