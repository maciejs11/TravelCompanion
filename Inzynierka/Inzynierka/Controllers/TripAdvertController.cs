using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inzynierka.Models.ApplicationUsers;
using Inzynierka.Models.TripAdverts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Inzynierka.Controllers
{
    public class TripAdvertController : Controller
    {
        private readonly ITripAdvertRepository _tripAdvertRepository;
        private readonly UserManager<ApplicationUser> _userManager;

        public TripAdvertController(ITripAdvertRepository tripAdvertRepository, UserManager<ApplicationUser> userManager)
        {
            _tripAdvertRepository = tripAdvertRepository;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Ogłoszenia";
            var tripAdverts = _tripAdvertRepository.GetAllTripAdverts().OrderByDescending(t => t.AdvertDate);

            return View(tripAdverts);
        }

       
        [Authorize]
        public IActionResult AddTripAdvert()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult AddTripAdvert(TripAdvert tripAdvert)
        {
            if (ModelState.IsValid)
            {
                _tripAdvertRepository.AddTripAdvert(tripAdvert);
                return RedirectToAction("Index");
            }
            return View(tripAdvert);
        }

        public IActionResult AddTripAdvertComplete()
        {
            return View();
        }

    }
}
