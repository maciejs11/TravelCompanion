using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inzynierka.Models.UserProfiles;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Inzynierka.Controllers
{
    public class UserProfileController : Controller
    {
        private readonly IUserProfileRepository _userProfileRepository;

        public UserProfileController(IUserProfileRepository userProfileRepository)
        {
            _userProfileRepository = userProfileRepository;
        }
        public IActionResult Index(String id)
        {
            Models.ApplicationUsers.ApplicationUser userProfiles;
            if (String.IsNullOrEmpty(id))
            {
                 userProfiles = _userProfileRepository.GetUserProfile();
            }
            else
            {
                 userProfiles = _userProfileRepository.GetUserProfileByEmail(id);
            }
            return View(userProfiles);
        }
    }
}
