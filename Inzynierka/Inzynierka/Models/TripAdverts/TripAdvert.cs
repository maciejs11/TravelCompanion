using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Inzynierka.Models.TripAdverts
{
    public class TripAdvert
    {
        public Guid TripAdvertID { get; set; }
        public string Title { get; set; }       
        public string Content { get; set; }      
        public string Country { get; set; }
        public DateTime AdvertDate { get; set; } = DateTime.Now;
        public DateTime ExpireDate { get; set; }
    }
}