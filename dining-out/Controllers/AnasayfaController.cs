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
    public class AnasayfaController : Controller
    {
        private readonly ILogger<AnasayfaController> _logger;

        public AnasayfaController(ILogger<AnasayfaController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            sehirleriDoldur();
            kisiSayisiDoldur();
            istanbulIlceleriDoldur();
            RestaurantSearchVM sample = new RestaurantSearchVM();
            sample.BookTableDate = DateTime.Now;
            sample.Capacity = 2;
            sample.CityId = "34";
            sample.DistrictId = "1";
            return View("Index", sample);
        }

        [HttpGet]
        public IActionResult RestaurantSearch(RestaurantSearchVM restaurantSearchVM)
        {
            sehirleriDoldur();
            kisiSayisiDoldur();
            istanbulIlceleriDoldur();
            restaurantAra(restaurantSearchVM);
            return View("Restaurant", restaurantSearchVM);
        }

        private void restaurantAra(RestaurantSearchVM restaurantSearchVM)
        {
            diningoutContext _context = new diningoutContext();
            List<RestaurantVM> restaurants = new List<RestaurantVM>();
            IQueryable<Restaurant> restaurantsQuery = _context.Restaurants
                                .Where(res => res.DistrictId.Equals(Int32.Parse(restaurantSearchVM.DistrictId.ToString())))
                                .Where(res => res.CityId.Equals(Int32.Parse(restaurantSearchVM.CityId.ToString())));
            if (restaurantSearchVM.Name != null)
            {
                restaurantsQuery=restaurantsQuery.Where(res => res.Name.Contains(restaurantSearchVM.Name) || res.SystemDefinitionName.Contains(restaurantSearchVM.Name));
            }

            List<Restaurant> restaurantsList = restaurantsQuery.ToList<Restaurant>();
            foreach(Restaurant restaurant in restaurantsList)
            {
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
                restaurantVM.CoverImg = restaurant.CoverImg;
                restaurantVM.SystemDefinitionName = restaurant.SystemDefinitionName;
                if (restaurant.Desc != null && restaurant.Desc.Length > 100)
                {
                    restaurantVM.Desc = restaurant.Desc.Substring(0, 100);
                }
                else
                {
                    restaurantVM.Desc = restaurant.Desc;
                }
                restaurants.Add(restaurantVM);
                restaurants.Add(restaurantVM);
                restaurants.Add(restaurantVM);
                restaurants.Add(restaurantVM);
                restaurants.Add(restaurantVM);
                restaurants.Add(restaurantVM);
            }

            ViewBag.Restaurants = restaurants;

        }

        public void kisiSayisiDoldur()
        {
            ViewBag.KisilerData = StaticDataManagerUtility.kisiSayisiListesi();
        }

        public void sehirleriDoldur()
        {
            List<KeyValueVM> cities = new List<KeyValueVM>();
            cities.Add(new KeyValueVM("01", "Adana"));
            cities.Add(new KeyValueVM("06", "Ankara"));
            cities.Add(new KeyValueVM("26", "Eskişehir"));
            cities.Add(new KeyValueVM("34", "İstanbul"));
            ViewBag.CitiesData = cities;
        }

        public void istanbulIlceleriDoldur()
        {
            List<KeyValueVM> districties = new List<KeyValueVM>();
            districties.Add(new KeyValueVM("1", "Kadıköy"));
            districties.Add(new KeyValueVM("2", "Maltepe"));
            districties.Add(new KeyValueVM("3", "Pendik"));
            districties.Add(new KeyValueVM("4", "Beşiktaş"));
            districties.Add(new KeyValueVM("5", "Avcılar"));
            districties.Add(new KeyValueVM("6", "Beylikdüzü"));
            ViewBag.DistrictiesData = districties;
        }

        // cityId : CityId
        [HttpPost]
        public JsonResult GetDistrictiesByCity(int cityId)
        {
            List<KeyValueVM> districties = new List<KeyValueVM>();
            districties.Add(new KeyValueVM("01", "Adana"));
            districties.Add(new KeyValueVM("06", "Ankara"));
            districties.Add(new KeyValueVM("26", "Eskişehir"));
            districties.Add(new KeyValueVM("34", "İstanbul"));
            return Json(districties);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Hata()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
