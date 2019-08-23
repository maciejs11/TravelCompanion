using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inzynierka.Models.TripAdvert
{
    public class TripAdvert
    {
        public Guid TripAdvertID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Country { get; set; }
        public DateTime AdvertDate { get; set; }
    }
}
