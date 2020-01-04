using Inzynierka.Models.ApplicationUsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inzynierka.Models.UserProfiles
{
    public interface IUserProfileRepository
    {
        ApplicationUser GetUserProfile();
    }
}
