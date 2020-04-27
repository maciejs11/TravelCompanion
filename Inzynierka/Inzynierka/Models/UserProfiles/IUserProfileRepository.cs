using Inzynierka.Models.ApplicationUsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inzynierka.Models.TripAdverts;

namespace Inzynierka.Models.UserProfiles
{
    public interface IUserProfileRepository
    {
       ApplicationUser GetUserProfile();
       ApplicationUser GetUserProfileByEmail(string email);
       IEnumerable<TripAdvert> GetTripAdvertsByUserId(string email);
       IEnumerable<TripAdvert> GetMyTripAdverts();
        IEnumerable<ApplicationUser> Search(string searchTerm);


    }
}
