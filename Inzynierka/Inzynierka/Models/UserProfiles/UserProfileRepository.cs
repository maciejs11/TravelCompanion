using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Inzynierka.Data;
using Inzynierka.Models.ApplicationUsers;
using Microsoft.AspNetCore.Http;

namespace Inzynierka.Models.UserProfiles
{
    public class UserProfileRepository : IUserProfileRepository
    {
        private readonly AppDbContext _appDbContext;
        public readonly IHttpContextAccessor _httpContextAccessor;

        public UserProfileRepository(AppDbContext appDbContext, IHttpContextAccessor httpContextAccessor)
        {
            _appDbContext = appDbContext;
            _httpContextAccessor = httpContextAccessor;
        }

        public ApplicationUser GetUserProfile()
        {
            string UserId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            return _appDbContext.ApplicationUsers.Where(u => u.Id ==UserId).Single();
        }
    }
}
