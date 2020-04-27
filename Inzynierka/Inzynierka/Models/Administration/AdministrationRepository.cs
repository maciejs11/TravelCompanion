using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inzynierka.Models.ApplicationUsers;
using Microsoft.AspNetCore.Identity;

namespace Inzynierka.Models.Administration
{
    public class AdministrationRepository : IAdministrationRepository
    {
        public readonly UserManager<ApplicationUser> _userManager;

        public AdministrationRepository(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public IEnumerable<ApplicationUser> Search(string search)
        {
            return _userManager.Users.Where(x => x.Email.Contains(search));
        }
    }
}
