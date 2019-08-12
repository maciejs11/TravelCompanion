using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelCompanion.Models;

namespace TravelCompanion.Models
{
    public class Advert
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Country { get; set; }
        public DateTime Date { get; set; }
        public User User { get; set; }

    }
}
