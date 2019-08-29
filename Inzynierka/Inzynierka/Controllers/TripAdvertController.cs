using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inzynierka.Models.TripAdvert;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Inzynierka.Controllers
{
    public class TripAdvertController : Controller
    {
        private readonly ITripAdvertRepository _tripAdvertRepository;

        public TripAdvertController(ITripAdvertRepository tripAdvertRepository)
        {
            _tripAdvertRepository = tripAdvertRepository;
        }

        public IActionResult Index()
        {
            ViewBag.Title = "Ogłoszenia";
            var tripAdverts = _tripAdvertRepository.GetAllTripAdverts().OrderByDescending(t => t.AdvertDate);

            return View(tripAdverts);
        }

        public IActionResult AddTripAdvert()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddTripAdvert(TripAdvert tripAdvert)
        {
            _tripAdvertRepository.AddTripAdvert(tripAdvert);
            return RedirectToAction("AddTripAdvertComplete");
        }

        public IActionResult AddTripAdvertComplete()
        {
            return View();
        }

    }
}
