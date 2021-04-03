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
    public class DashboardSiparislerController : Controller
    {
        private readonly ILogger<DashboardSiparislerController> _logger;

        public DashboardSiparislerController(ILogger<DashboardSiparislerController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(siparisler());
        }

        [HttpPost]
        public IActionResult SiparisDurumGüncelle()
        {
            List<KeyValueVM> secilenSiparisler = new List<KeyValueVM>();
            List<KeyValueVM> secilenSiparisDurumları = new List<KeyValueVM>();
            foreach (string key in Request.Form.Keys)
            {
                if (key.Contains("secilenSiparis"))
                {
                    string[] splittedKey = key.Split("_");
                    string secilenSiparis = splittedKey[1];
                    string secilenSiparisValue = Request.Form[key].ToString();
                    if ("on".Equals(secilenSiparisValue))
                    {
                        KeyValueVM keyValueVM = new KeyValueVM(secilenSiparis, secilenSiparisValue);
                        secilenSiparisler.Add(keyValueVM);
                    }
                }

                if (key.Contains("siparisDurum"))
                {
                    string[] splittedKey = key.Split("_");
                    string secilenSiparis = splittedKey[1];
                    string secilenSiparisDurum = Request.Form[key].ToString();
                    KeyValueVM keyValueVM = new KeyValueVM(secilenSiparis, secilenSiparisDurum);
                    secilenSiparisDurumları.Add(keyValueVM);
                }
            }

            if (secilenSiparisler.Count <= 0)
            {
                ViewBag.BasariliSiparisGuncelle = false;
                ViewBag.Mesaj = "Sipariş durumu güncellemek için bir seçim yapmalısınız";
                return View("Index", siparisler());
            }

            diningoutContext dbContext = new diningoutContext();
            foreach (KeyValueVM siparis in secilenSiparisler)
            {
                foreach (KeyValueVM siparisDurum in secilenSiparisDurumları)
                {
                    if (siparis.Key.Equals(siparisDurum.Key))
                    {
                        BookTableOrderedItem bookTableOrderedItem = dbContext.BookTableOrderedItems.Where(sip => sip.Id.ToString().Equals(siparis.Key)).SingleOrDefault();
                        bookTableOrderedItem.Status = ConstantUtility.enumValueOfOrderedItemStatus(siparisDurum.Value);
                        dbContext.BookTableOrderedItems.Update(bookTableOrderedItem);
                        dbContext.SaveChanges();
                    }
                }
            }

            ViewBag.BasariliSiparisGuncelle = true;
            ViewBag.Mesaj = "Sipariş durumları güncellenmiştir";
            return View("Index",siparisler());
        }

        public SiparislerVM siparisler()
        {
            int userId = 1; // Login Kullanıcı olacak
            diningoutContext dbContext = new diningoutContext();
            User user = dbContext.Users.Where(user => user.Id.Equals(userId)).SingleOrDefault();
            List<BookTableOrderedItem> bookTableOrderedItems = dbContext.BookTableOrderedItems.Where(orderedItem => orderedItem.RestaurantId.ToString().Equals(userId.ToString())).ToList();

            List<BookTableOrderedItem> newBookTableOrderedItems = bookTableOrderedItems.Where(orderedItem => orderedItem.Status.ToString().Equals(ConstantUtility.OrderedItemStatus.NEW.ToString())).ToList();
            List<BookTableOrderedItem> serviceBookTableOrderedItems = bookTableOrderedItems.Where(orderedItem => orderedItem.Status.ToString().Equals(ConstantUtility.OrderedItemStatus.SERVICED.ToString())).ToList();
            List<BookTableOrderedItem> otherBookTableOrderedItems = bookTableOrderedItems.Where(orderedItem => orderedItem.Status.ToString().Equals(ConstantUtility.OrderedItemStatus.PURCHASED.ToString()) || orderedItem.Status.ToString().Equals(ConstantUtility.OrderedItemStatus.CANCELLED.ToString())).ToList();

            SiparislerVM siparislerVM = new SiparislerVM();
            siparislerVM.SiparisDurumlar = ConstantUtility.tumSiparisDurumlar();
            siparislerVM.newOrderedItems = Converters.convertModel(newBookTableOrderedItems);
            siparislerVM.servicedOrderedItems = Converters.convertModel(serviceBookTableOrderedItems);
            siparislerVM.otherOrderedItems = Converters.convertModel(otherBookTableOrderedItems);
            return siparislerVM;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Hata()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
