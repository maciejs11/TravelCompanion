using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inzynierka.Models.ApplicationUsers;
using Inzynierka.Models.TripAdverts;
using Inzynierka.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Inzynierka.Controllers
{
    public class TripAdvertController : Controller
    {
        private readonly ITripAdvertRepository _tripAdvertRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        public readonly IHttpContextAccessor _httpContextAccessor;

        public TripAdvertController(ITripAdvertRepository tripAdvertRepository, UserManager<ApplicationUser> userManager, IHttpContextAccessor httpContextAccessor)
        {
            _tripAdvertRepository = tripAdvertRepository;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;

        }

        public IActionResult Index()
        {
            TripAdvertsViewModel tripAdvertsViewModel = new TripAdvertsViewModel();
            tripAdvertsViewModel.TripAdverts = _tripAdvertRepository.GetAllTripAdverts().OrderByDescending(t => t.AdvertDate);
            tripAdvertsViewModel.PageTitle = "Ogłoszenia";
            return View(tripAdvertsViewModel);
        }

        [HttpGet]
        [Authorize]
        public IActionResult AddTripAdvert()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddTripAdvert(TripAdvert tripAdvert)
        {
            if (ModelState.IsValid)
            {
                tripAdvert.UserEmail = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Name).Value;
                tripAdvert.UserId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
                tripAdvert.UserFirstName = (await _userManager.GetUserAsync(HttpContext.User))?.FirstName;

                _tripAdvertRepository.AddTripAdvert(tripAdvert);
                return RedirectToAction("Index");
            }
            return View(tripAdvert);
        }

     
        public IActionResult AddTripAdvertComplete()
        {
            return View();
        }

        public IActionResult SearchTripAdverts(string search = null)
        {
            var foundTripAdverts = _tripAdvertRepository.Search(search);
            return View(foundTripAdverts);
        }

    }
}
