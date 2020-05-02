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
using System.Net.Mail;
using System.Net;

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
        private readonly ITripAdvertRepository _tripAdvertRepository;

        public UserProfileController(IUserProfileRepository userProfileRepository, UserManager<ApplicationUser> userManager,
            IHttpContextAccessor httpContextAccessor, SignInManager<ApplicationUser> signInManager, ITripAdvertRepository tripAdvertRepository)
        {
            _userManager = userManager;
            _userProfileRepository = userProfileRepository;
            _httpContextAccessor = httpContextAccessor;
            _signInManager = signInManager;
            _tripAdvertRepository = tripAdvertRepository;

        }
        public IActionResult Index()
        {
            UserProfileViewModel userProfileViewModel = new UserProfileViewModel();
            userProfileViewModel.PageTitle = "Mój profil";
                  
            userProfileViewModel.UserProfiles = _userProfileRepository.GetUserProfile();
            userProfileViewModel.TripAdverts = _userProfileRepository.GetMyTripAdverts();

            return View(userProfileViewModel);
        }
       
        public async Task<string> SendEmail(string email, string Message)
        {
            try
            {
                string userEmail = (await _userManager.GetUserAsync(HttpContext.User))?.Email;
                      
                var credentials = new NetworkCredential("travelcompanionn3@gmail.com", "iNzynI3rk@24");
               
                var mail = new MailMessage()
                {
                    From = new MailAddress("travelcompanionn3@gmail.com"),
                    Subject = "Wiadomosc prywatna od użytkownika z TravelCompanion.",
                    Body = "Użytkownik " + userEmail + " z serwisu TravelCompanion napisał do Ciebie wiadomość: " + "\n" + "\n" + "\"" + Message + "\"" +
                            "\n" + "\n" + "Możesz odpisać mu na jego e-mail " + userEmail + " lub napisać mu wiadomość wyszukując go i wchodząc na jego profil w serwisie TravelCompanion."
                };
                mail.IsBodyHtml = false;
                mail.To.Add(new MailAddress(email));
              
                var client = new SmtpClient()
                {
                    Port = 587,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Host = "smtp.gmail.com",
                    EnableSsl = true,
                    Credentials = credentials
                };
                client.Send(mail);
                return "Wysłano Email!";
            }
            catch (System.Exception e)
            {
                return e.Message;
            }
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

        public async Task<IActionResult> DeleteAccount()
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var user = await _userManager.FindByIdAsync(userId);

            if (user == null)
            {
                return View("NotFoundUser");
            }
            else
            {
                _tripAdvertRepository.DeleteTripAdvertByUserId(user.Id);
                await _signInManager.SignOutAsync();
                var result = await _userManager.DeleteAsync(user);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "TripAdvert");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View("Index", "TripAdvert");
        }

        [HttpPost]
        public async Task<IActionResult> EditUserProfile(ApplicationUser model)
        {
            var user = await _userManager.FindByIdAsync(model.Id);
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

        [HttpPost]
        public IActionResult DeleteTripAdvertUserProfile(Guid id)
        {
            _tripAdvertRepository.DeleteTripAdvertUserProfile(id);
            return RedirectToAction("Index");

        }
        [AllowAnonymous]
        public IActionResult SearchUsers(string search = null)
        {             
                var foundUsers = _userProfileRepository.Search(search);
                return View(foundUsers);           
        }
        
        

    }
}
