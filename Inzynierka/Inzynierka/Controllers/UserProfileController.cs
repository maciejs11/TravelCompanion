﻿using System;
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
        private readonly SignInManager<ApplicationUser> _signInManager;

        public UserProfileController(IUserProfileRepository userProfileRepository, UserManager<ApplicationUser> userManager,
            IHttpContextAccessor httpContextAccessor, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _userProfileRepository = userProfileRepository;
            _httpContextAccessor = httpContextAccessor;
            _signInManager = signInManager;

        }
        public IActionResult Index(String id)
        {
            UserProfileViewModel userProfileViewModel = new UserProfileViewModel();
            userProfileViewModel.PageTitle = "Mój profil";
                  
            userProfileViewModel.UserProfiles = _userProfileRepository.GetUserProfile();
            userProfileViewModel.TripAdverts = _userProfileRepository.GetMyTripAdverts();

            return View(userProfileViewModel);
        }

        public async Task<IActionResult> OtherUserProfile(String id)
        {
            var user = await _userManager.FindByEmailAsync(id);
            var loggedInUser = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Name).Value;

            if (user == null)
            {
                return View("NotfoundUser");
            }
            else if(user.Email == loggedInUser){
                return RedirectToAction("Index", "UserProfile");
            }
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

        [HttpPost]
        public async Task<IActionResult> EditUserProfile(ApplicationUser model)
        {
            var user = await _userManager.FindByIdAsync(model.Id);
            //var idUser = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.Age = model.Age;
            user.Gender = model.Gender;
            user.About = model.About;

            var result = await _userManager.UpdateAsync(user);

            if(result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            foreach(var err in result.Errors)
            {
                ModelState.AddModelError("", err.Description);
            }
            return View(model);

        }

    }
}
