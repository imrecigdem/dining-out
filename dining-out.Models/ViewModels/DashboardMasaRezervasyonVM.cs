using System;
namespace dining_out.Models.ViewModels
{
    public class DashboardMasaRezervasyonVM:BaseUserVM
    {
        public DashboardMasaRezervasyonVM()
        {
        }

        public BookTableRezervationVM rezervationVM { get; set; }
        public RestaurantVM restaurantVM { get; set; }
        public string EklenenecekKullaniciIsmi { get; set; }
    }
}
