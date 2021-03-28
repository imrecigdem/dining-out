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
        public IActionResult OdemeAl(int masaRezervationId)
        {
            diningoutContext dbContext = new diningoutContext();
            List<KeyValueVM> odemeYapilacakSiparisler = new List<KeyValueVM>();
            List<KeyValueVM> secilenSiparisler = new List<KeyValueVM>();
            foreach (string key in Request.Form.Keys)
            {
                //Seçilen Siparişler gelen istekten alınıyor
                if (key.Contains("secilenSiparis"))
                {
                    string[] splittedKey = key.Split("_");
                    string secilenSiparis = splittedKey[1];
                    string secilenSiparisValue = Request.Form[key].ToString();
                    KeyValueVM keyValueVM = new KeyValueVM(secilenSiparis, secilenSiparisValue);
                    if ("on".Equals(secilenSiparisValue))
                    {
                        secilenSiparisler.Add(keyValueVM);
                    }
                }

                //Seçilen Siparişler için ödeme yapacak olan kullanıcılar gelen istekten alınıyor
                if (key.Contains("odemeYapan"))
                {
                    string[] splittedKey = key.Split("_");
                    string odemeYapilacakSiparis = splittedKey[1];
                    string odemeYapacakKisi = Request.Form[key].ToString();
                    KeyValueVM keyValueVM = new KeyValueVM(odemeYapilacakSiparis, odemeYapacakKisi);
                    odemeYapilacakSiparisler.Add(keyValueVM);
                }    
            }

            if (secilenSiparisler.Count <= 0)
            {
                ViewBag.BasariliOdeme = false;
                ViewBag.BasariliGenel = false;
                ViewBag.HataMesajiOdeme = "Ödeme yapmak için sipariş seçmelisiniz";
                ViewBag.HataMesajiDetay = "Siparişler Detayı alanında hata - Ödeme yapmak için sipariş seçmelisiniz";
                DashboardMasaRezervasyonVM dashboardMasaRezervasyonVM1 = indexSayfasiModel(masaRezervationId);
                return View("Index", dashboardMasaRezervasyonVM1);
            }

            //Secilen Siparişler ile o siparişlerin ödemesini yapacak olan kullanicilar eşleniyor.
            List<KeyValueVM> odemeSayfasiSiparisler = new List<KeyValueVM>();
            List<int> odemeSayfasiSiparislerId = new List<int>();
            foreach (KeyValueVM secilenSiparis in secilenSiparisler)
            {
                foreach(KeyValueVM odemeYapilacak in odemeYapilacakSiparisler)
                {
                    if (odemeYapilacak.Key.Equals(secilenSiparis.Key))
                    {
                        KeyValueVM odemeSayfasi = new KeyValueVM(secilenSiparis.Key, odemeYapilacak.Value);
                        odemeSayfasiSiparisler.Add(odemeSayfasi);
                        odemeSayfasiSiparislerId.Add(Int32.Parse(odemeYapilacak.Key));
                    }
                }
            }

            decimal toplam = 0;
            List<BookTableOrderedItemVM> bookTableOrderedItemsVM = new List<BookTableOrderedItemVM>();
            List<BookTableOrderedItem> bookTableOrderedItems = dbContext.BookTableOrderedItems.Where(orderedItem => odemeSayfasiSiparislerId.Contains(orderedItem.Id)).ToList();
            foreach(BookTableOrderedItem bookTableOrderedItem in bookTableOrderedItems)
            {
                BookTableOrderedItemVM bookTableOrderedItemVM = Converters.convertModel(bookTableOrderedItem);
                foreach(KeyValueVM keyValueVM in odemeSayfasiSiparisler)
                {
                    if (keyValueVM.Key.Equals(bookTableOrderedItem.Id.ToString()))
                    {
                        bookTableOrderedItemVM.PurchasedUserName = keyValueVM.Value;
                    }
                }
                bookTableOrderedItemsVM.Add(bookTableOrderedItemVM);
                toplam = toplam + bookTableOrderedItemVM.Price;
            }

            OdemeAlVM odemeAlVM = new OdemeAlVM();
            odemeAlVM.BookTableOrderedItemsVM = bookTableOrderedItemsVM;
            odemeAlVM.Toplam = toplam;
            odemeAlVM.MasaRezervationId = masaRezervationId;
            odemeAlVM.CartType = "CreditCard";

            return View("OdemeAl", odemeAlVM);
        }

        [HttpPost]
        public IActionResult OdemeYap(int masaRezervationId, OdemeAlVM odemeAlVM)
        {
            if (Request.Form.Keys.Contains("kuponUygula"))
            {
                string promosyon = odemeAlVM.Promosyon;
                odemeAlVM.PromosyonMiktari = 5 ;
                odemeAlVM.Toplam = odemeAlVM.Toplam - odemeAlVM.PromosyonMiktari;
                return View("OdemeAl", odemeAlVM);
            }

            if (odemeAlVM.CartHolder==null || odemeAlVM.CartHolder.Count()<=0)
            {
                ViewBag.BasariliOdeme = false;
                ViewBag.Mesaj = "Kart Üzerindeki İsimi girmelisiniz ";
                return View("OdemeAl", odemeAlVM);
            }

            if (odemeAlVM.CardValidDate == null || odemeAlVM.CardValidDate.Count() <= 0)
            {
                ViewBag.BasariliOdeme = false;
                ViewBag.Mesaj = "Kart Geçerlilik Süresini girmelisiniz ";
                return View("OdemeAl", odemeAlVM);
            }

            if (odemeAlVM.CartNumber == null || odemeAlVM.CartNumber.Count() <= 0)
            {
                ViewBag.BasariliOdeme = false;
                ViewBag.Mesaj = "Kart Numarasını girmelisiniz";
                return View("OdemeAl", odemeAlVM);
            }

            if (odemeAlVM.CardSecurityNumber == null || odemeAlVM.CardSecurityNumber.Count() <= 0)
            {
                ViewBag.BasariliOdeme = false;
                ViewBag.Mesaj = "Kart Güvelik Numarasını girmelisiniz";
                return View("OdemeAl", odemeAlVM);
            }

            return View("OdemeAl", odemeAlVM);
        }

        [HttpPost]
        public IActionResult KisiEkle(int masaRezervationId)
        {
            string kullaniciIsmi = Request.Form["eklenenecekKullaniciIsmi"].ToString();
            if(kullaniciIsmi==null || kullaniciIsmi.Trim().Count() == 0)
            {
                ViewBag.Basarili = false;
                ViewBag.BasariliGenel = false;
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
                ViewBag.BasariliGenel = false;
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
                    ViewBag.BasariliGenel = false;
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
            List<BookTableOrderedItem> bookTableOrderedItems = dbContext.BookTableOrderedItems.Where(ordered => ordered.RezervationId.Equals(masaRezervationId)).ToList();

            BookTableRezervationVM rezervationVM = Converters.convertModel(bookTableRezervation);
            RestaurantVM restaurantVM = Converters.convertModel(bookTableRezervation.Restaurant);

            decimal totalOrderedPriceByUser=0;
            List<BookTableOrderedItemVM> bookTableOrderedItemsVM = new List<BookTableOrderedItemVM>();
            foreach (BookTableOrderedItem bookTableOrderedItem in bookTableOrderedItems)
            {
                BookTableOrderedItemVM bookTableOrderedItemVM=Converters.convertModel(bookTableOrderedItem);
                bookTableOrderedItemsVM.Add(bookTableOrderedItemVM);
                if (bookTableOrderedItem.UserId.Equals(userId) && ConstantUtility.OrderedItemStatus.SERVICED.ToString().Equals(bookTableOrderedItem.Status))
                {
                    totalOrderedPriceByUser = totalOrderedPriceByUser + bookTableOrderedItem.MenuItem.Price;
                }
            }
            
            DashboardMasaRezervasyonVM dashboardMasaRezervasyonVM = new DashboardMasaRezervasyonVM();
            dashboardMasaRezervasyonVM.rezervationVM = rezervationVM;
            dashboardMasaRezervasyonVM.restaurantVM = restaurantVM;
            dashboardMasaRezervasyonVM.user = Converters.convertModel(user);
            dashboardMasaRezervasyonVM.orderedItemsVM = bookTableOrderedItemsVM;
            dashboardMasaRezervasyonVM.TotalOrderedPriceByUser = totalOrderedPriceByUser;
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
