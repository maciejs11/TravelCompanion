using Inzynierka.Models.ApplicationUsers;
using Inzynierka.Models.TripAdverts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inzynierka.ViewModels
{
    public class TripAdvertsViewModel
    {
        public List<TripAdvert> TripAdverts { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
