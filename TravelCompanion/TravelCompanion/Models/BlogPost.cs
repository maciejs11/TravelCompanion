using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TravelCompanion.Models;

namespace TravelCompanion.Models
{
    public class BlogPost
    {
        public int ID { get; set; }
        public User User { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }

    }
}
