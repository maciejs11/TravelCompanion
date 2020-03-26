using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inzynierka.Models.UserProfiles;
using Microsoft.AspNetCore.Mvc;
using Inzynierka.Models.TripAdverts;
using Inzynierka.ViewModels;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Inzynierka.Controllers
{
    [Authorize]
    public class UserProfileController : Controller
    {
        private readonly IUserProfileRepository _userProfileRepository;

        public UserProfileController(IUserProfileRepository userProfileRepository)
        {
            _userProfileRepository = userProfileRepository;
        }
        public IActionResult Index(String id)
        {
            UserProfileViewModel userProfileViewModel = new UserProfileViewModel();
            userProfileViewModel.PageTitle = "Mój profil";
           
            if (String.IsNullOrEmpty(id))
            {
                userProfileViewModel.UserProfiles = _userProfileRepository.GetUserProfile();
                userProfileViewModel.TripAdverts = _userProfileRepository.GetMyTripAdverts();

            }
            else
            {
                userProfileViewModel.UserProfiles = _userProfileRepository.GetUserProfileByEmail(id);
                userProfileViewModel.TripAdverts = _userProfileRepository.GetTripAdvertsByUserId(id);
            }

            

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
    }
}
