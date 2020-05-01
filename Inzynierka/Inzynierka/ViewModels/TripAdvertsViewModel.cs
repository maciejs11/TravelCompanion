using Inzynierka.Models.ApplicationUsers;
using Inzynierka.Models.ChatEmail;
using Inzynierka.Models.TripAdverts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inzynierka.ViewModels
{
    public class TripAdvertsViewModel
    {
        public IEnumerable<TripAdvert> TripAdverts { get; set; }
        public string PageTitle { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public EmailMessage EmailMessage { get; set; }
    }
}
