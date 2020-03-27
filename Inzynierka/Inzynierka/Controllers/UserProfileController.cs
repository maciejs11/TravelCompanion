using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inzynierka.Models.UserProfiles;
using Microsoft.AspNetCore.Mvc;
using Inzynierka.Models.TripAdverts;
using Inzynierka.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Inzynierka.Models.ApplicationUsers;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Inzynierka.Controllers
{
    [Authorize]
    public class UserProfileController : Controller
    {
        private readonly IUserProfileRepository _userProfileRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        public readonly IHttpContextAccessor _httpContextAccessor;

        public UserProfileController(IUserProfileRepository userProfileRepository, UserManager<ApplicationUser> userManager, IHttpContextAccessor httpContextAccessor)
        {
            _userManager = userManager;
            _userProfileRepository = userProfileRepository;
            _httpContextAccessor = httpContextAccessor;

        }
        public IActionResult Index(String id)
        {
            UserProfileViewModel userProfileViewModel = new UserProfileViewModel();
            userProfileViewModel.PageTitle = "Mój profil";
                  
            userProfileViewModel.UserProfiles = _userProfileRepository.GetUserProfile();
            userProfileViewModel.TripAdverts = _userProfileRepository.GetMyTripAdverts();

            return View(userProfileViewModel);
        }

        public IActionResult OtherUserProfile(String id)
        {
            UserProfileViewModel userProfileViewModel = new UserProfileViewModel();
            userProfileViewModel.PageTitle = "Profil użytkownika";
  
            userProfileViewModel.UserProfiles = _userProfileRepository.GetUserProfileByEmail(id);
            userProfileViewModel.TripAdverts = _userProfileRepository.GetTripAdvertsByUserId(id);
           
            return View(userProfileViewModel);
        }

        [HttpGet]
        public async Task<IActionResult> EditUserProfile(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            //var idUser = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            var model = new ApplicationUser
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Age = user.Age,
                Gender = user.Gender,
                About = user.About,
            };

            return View(model);
        }

    }
}
