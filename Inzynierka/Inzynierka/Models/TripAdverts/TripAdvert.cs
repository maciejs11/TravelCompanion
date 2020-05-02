using Inzynierka.Models.ApplicationUsers;
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
        [Required(ErrorMessage ="Musisz wpisać tytuł.")]
        [StringLength(50)]
        public string Title { get; set; }
        [Required(ErrorMessage = "Musisz wpisać treść.")]
        public string Content { get; set; }
        [Required(ErrorMessage = "Musisz wpisać kraj.")]
        [StringLength(50)]
        public string Country { get; set; }
        public DateTime AdvertDate { get; set; } = DateTime.Now;
        public string UserEmail { get; set; }
        public string UserFirstName { get; set; }

        public string UserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; } 
    }
}