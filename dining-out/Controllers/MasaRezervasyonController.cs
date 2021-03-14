using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using dining_out.Models.ViewModels;
using dining_out.Models.DbModels;
using dining_out.Utility;

namespace dining_out.Controllers
{
    public class MasaRezervasyonController : Controller
    {
        private readonly ILogger<MasaRezervasyonController> _logger;

        public MasaRezervasyonController(ILogger<MasaRezervasyonController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index(int restaurantId)
        {
            diningoutContext _context = new diningoutContext();
            RestaurantDetayı(restaurantId);
            ViewBag.KisilerData = StaticDataManagerUtility.kisiSayisiListesi();
            return View("Index", new MasaRezervasyonVM(restaurantId));
        }

        [HttpPost]
        [Route("/MasaRezervasyon/RezervasyonYap/{restaurantId:int}")]
        public IActionResult RezervasyonYap(int restaurantId, MasaRezervasyonVM masaRezervasyonVM)
        {
            diningoutContext _context = new diningoutContext();
            RestaurantDetayı(restaurantId);
            ViewBag.KisilerData = StaticDataManagerUtility.kisiSayisiListesi();
            ViewBag.Basarili = true;
            return View("Index", new MasaRezervasyonVM(restaurantId));
        }

        public void RestaurantDetayı(int restaurantId)
        {
            diningoutContext _context = new diningoutContext();
            Restaurant restaurant = _context.Restaurants.Where(res => res.Id.Equals(restaurantId)).Single();
            RestaurantVM restaurantVM = new RestaurantVM();
            restaurantVM.Id = restaurant.Id;
            restaurantVM.Address = restaurant.Address;
            restaurantVM.Capacity = restaurant.Capacity;
            restaurantVM.City = restaurant.City;
            restaurantVM.CityId = restaurant.CityId;
            restaurantVM.District = restaurant.District;
            restaurantVM.DistrictId = restaurant.DistrictId;
            restaurantVM.Logo = restaurant.Logo;
            restaurantVM.Name = restaurant.Name;
            restaurantVM.Desc = restaurant.Desc;
            restaurantVM.CoverImg = restaurant.CoverImg;
            restaurantVM.SystemDefinitionName = restaurant.SystemDefinitionName;
            ViewBag.Restaurant = restaurantVM;

        }

    }
}
