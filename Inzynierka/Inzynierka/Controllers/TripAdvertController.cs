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
            var tripAdverts = _tripAdvertRepository.GetAllTripAdverts().OrderBy(t => t.AdvertDate);



            return View(tripAdverts);
        }
    }
}
