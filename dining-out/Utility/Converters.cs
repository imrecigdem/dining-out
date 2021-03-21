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
using System.IO;

namespace dining_out.Utility
{
    public static class Converters
    {
        public static RestaurantVM convertModel(Restaurant restaurant)
        {
            RestaurantVM restaurantVM = new RestaurantVM();
            restaurantVM.Address = restaurant.Address;
            restaurantVM.Capacity = restaurant.Capacity;
            restaurantVM.City = restaurant.City;
            restaurantVM.Desc = restaurant.Desc;
            restaurantVM.District = restaurant.District;
            restaurantVM.Id = restaurant.Id;
            restaurantVM.Name = restaurant.Name;
            restaurantVM.SystemDefinitionName = restaurant.SystemDefinitionName;
            restaurantVM.UserId = restaurant.UserId;

            List<BookTableRezervation> bookTableRezervations = restaurant.BookTableRezervations.ToList();
            int newBookings = 0, approvedBookings = 0, closedBookings = 0;
            foreach (BookTableRezervation bookTableRezervation in bookTableRezervations)
            {
                if (ConstantUtility.IsRezervationStatusNEW(bookTableRezervation.RezervationStatus))
                {
                    ++newBookings;
                }
                if (ConstantUtility.IsRezervationStatusAPPROVED(bookTableRezervation.RezervationStatus))
                {
                    ++approvedBookings;
                }
                if (ConstantUtility.IsRezervationStatusCANCELLED(bookTableRezervation.RezervationStatus) || ConstantUtility.IsRezervationStatusCLOSED(bookTableRezervation.RezervationStatus))
                {
                    ++newBookings;
                }
            }
            restaurantVM.NewBookingCount = newBookings;
            restaurantVM.ApprovedBookingCount = approvedBookings;
            restaurantVM.ClosedBookingCount = closedBookings;
            return restaurantVM;
        }

        public static string GetUniqueFileName(string fileName)
        {
            fileName = Path.GetFileName(fileName);
            return Path.GetFileNameWithoutExtension(fileName)
                      + "_"
                      + Guid.NewGuid().ToString().Substring(0, 4)
                      + Path.GetExtension(fileName);
        }
    }
}
