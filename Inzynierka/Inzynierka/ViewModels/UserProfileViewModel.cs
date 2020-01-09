using Inzynierka.Models.ApplicationUsers;
using Inzynierka.Models.TripAdverts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inzynierka.ViewModels
{
    public class UserProfileViewModel
    {
        public ApplicationUser UserProfiles { get; set; }
        public IEnumerable<TripAdvert> TripAdverts { get; set; }
    }
}
