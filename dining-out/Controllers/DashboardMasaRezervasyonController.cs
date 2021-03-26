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
    public class DashboardMasaRezervasyonController : Controller
    {
        private readonly ILogger<DashboardMasaRezervasyonController> _logger;

        public DashboardMasaRezervasyonController(ILogger<DashboardMasaRezervasyonController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index(int masaRezervationId)
        {
            DashboardMasaRezervasyonVM dashboardMasaRezervasyonVM= indexSayfasiModel(masaRezervationId);
            return View(dashboardMasaRezervasyonVM);
        }

        [HttpGet]
        public IActionResult RezervasyonOnay(int masaRezervationId)
        {
            diningoutContext dbContext = new diningoutContext();
            BookTableRezervation bookTableRezervation = dbContext.BookTableRezervations.Where(bookTable => bookTable.Id.Equals(masaRezervationId)).First();
            bookTableRezervation.RezervationStatus = ConstantUtility.RezervationStatus.APPROVED.ToString();
            dbContext.BookTableRezervations.Update(bookTableRezervation);
            dbContext.SaveChanges();
            DashboardMasaRezervasyonVM dashboardMasaRezervasyonVM = indexSayfasiModel(masaRezervationId);
            return View("Index", dashboardMasaRezervasyonVM);
        }

        [HttpGet]
        public IActionResult RezervasyonKapat(int masaRezervationId)
        {
            diningoutContext dbContext = new diningoutContext();
            BookTableRezervation bookTableRezervation = dbContext.BookTableRezervations.Where(bookTable => bookTable.Id.Equals(masaRezervationId)).First();
            bookTableRezervation.RezervationStatus = ConstantUtility.RezervationStatus.CLOSED.ToString();
            dbContext.BookTableRezervations.Update(bookTableRezervation);
            dbContext.SaveChanges();
            DashboardMasaRezervasyonVM dashboardMasaRezervasyonVM = indexSayfasiModel(masaRezervationId);
            return View("Index", dashboardMasaRezervasyonVM);
        }

        [HttpGet]
        public IActionResult RezervasyonIptal(int masaRezervationId)
        {
            diningoutContext dbContext = new diningoutContext();
            BookTableRezervation bookTableRezervation = dbContext.BookTableRezervations.Where(bookTable => bookTable.Id.Equals(masaRezervationId)).First();
            bookTableRezervation.RezervationStatus = ConstantUtility.RezervationStatus.CANCELLED.ToString();
            dbContext.BookTableRezervations.Update(bookTableRezervation);
            dbContext.SaveChanges();
            DashboardMasaRezervasyonVM dashboardMasaRezervasyonVM = indexSayfasiModel(masaRezervationId);
            return View("Index", dashboardMasaRezervasyonVM);
        }

        [HttpPost]
        public IActionResult KisiEkle(int masaRezervationId)
        {
            string kullaniciIsmi = Request.Form["eklenenecekKullaniciIsmi"].ToString();
            if(kullaniciIsmi==null || kullaniciIsmi.Trim().Count() == 0)
            {
                ViewBag.Basarili = false;
                ViewBag.HataMesaji = "Geçerli kullanıcı ismi girmelisiniz";
                ViewBag.HataMesajiDetay = "Rezervasyona Dahil edilen kişiler alanında hata - Geçerli kullanıcı ismi girmelisiniz";
                DashboardMasaRezervasyonVM dashboardMasaRezervasyonVM1 = indexSayfasiModel(masaRezervationId);
                return View("Index", dashboardMasaRezervasyonVM1);
            }
            diningoutContext dbContext = new diningoutContext();
            User user = dbContext.Users.Where(user => user.UserName.Equals(kullaniciIsmi)).FirstOrDefault();
            if (user == null)
            {
                ViewBag.Basarili = false;
                ViewBag.HataMesaji = "Bu isimde kullanıcı bulunmuyor";
                ViewBag.HataMesajiDetay = "Rezervasyona Dahil edilen kişiler alanında hata - Bu isimde kullanıcı bulunmuyor";
                DashboardMasaRezervasyonVM dashboardMasaRezervasyonVM2 = indexSayfasiModel(masaRezervationId);
                return View("Index", dashboardMasaRezervasyonVM2);
            }

            BookTableRezervation bookTableRezervation = dbContext.BookTableRezervations.Where(rez => rez.Id.Equals(masaRezervationId)).FirstOrDefault();
            List<BookTableAttendee> bookTableAttendees = bookTableRezervation.BookTableAttendees.ToList();

            foreach(BookTableAttendee attendee in bookTableAttendees)
            {
                if (attendee.User.UserName.Equals(kullaniciIsmi))
                {
                    ViewBag.Basarili = false;
                    ViewBag.HataMesaji = "Eklenmiş bir kullanıcı ismi girdiniz";
                    ViewBag.HataMesajiDetay = "Rezervasyona Dahil edilen kişiler alanında hata - Eklenmiş bir kullanıcı ismi girdiniz";
                    DashboardMasaRezervasyonVM dashboardMasaRezervasyonVM2 = indexSayfasiModel(masaRezervationId);
                    return View("Index", dashboardMasaRezervasyonVM2);
                }
            }
            
            BookTableAttendee bookTableAttendee = new BookTableAttendee();
            bookTableAttendee.BooktableRezervationId = masaRezervationId;
            bookTableAttendee.UserId = user.Id;
            dbContext.BookTableAttendees.Add(bookTableAttendee);
            dbContext.SaveChanges();
            
            DashboardMasaRezervasyonVM dashboardMasaRezervasyonVM3 = indexSayfasiModel(masaRezervationId);
            return View("Index", dashboardMasaRezervasyonVM3);
        }

        public DashboardMasaRezervasyonVM indexSayfasiModel(int masaRezervationId)
        {
            int userId = 1; // Login Kullanıcı olacak
            diningoutContext dbContext = new diningoutContext();
            User user = dbContext.Users.Where(user => user.Id.Equals(userId)).First();
            BookTableRezervation bookTableRezervation = dbContext.BookTableRezervations.Where(bookTable => bookTable.Id.Equals(masaRezervationId)).First();

            BookTableRezervationVM rezervationVM = Converters.convertModel(bookTableRezervation);
            RestaurantVM restaurantVM = Converters.convertModel(bookTableRezervation.Restaurant);

            DashboardMasaRezervasyonVM dashboardMasaRezervasyonVM = new DashboardMasaRezervasyonVM();
            dashboardMasaRezervasyonVM.rezervationVM = rezervationVM;
            dashboardMasaRezervasyonVM.restaurantVM = restaurantVM;
            dashboardMasaRezervasyonVM.user = Converters.convertModel(user);
            return dashboardMasaRezervasyonVM;
        }

        public ActionResult KullaniciGetir(string q)
        {
            try
            {
                diningoutContext dbContext = new diningoutContext();
                var names = dbContext.Users.Where(usr => usr.UserName.Contains(q)).Select(p => p.UserName).Take(10);
                string content = string.Join<string>("\n", names);
                return Content(content);
            }
            catch
            {
                return BadRequest();
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Hata()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
