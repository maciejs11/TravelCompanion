using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inzynierka.Data;
using Inzynierka.Models.ApplicationUsers;

namespace Inzynierka.Models.UserProfiles
{
    public class UserProfileRepository : IUserProfileRepository
    {
        private readonly AppDbContext _appDbContext;

        public UserProfileRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public ApplicationUser GetUserProfile()
        {
            throw new NotImplementedException();
        }
    }
}
