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
            restaurantVM.Menu = convertModel(restaurant.Menus);
            return restaurantVM;
        }

        public static MenuVm convertModel(ICollection<Menu> menus)
        {
            MenuVm menuVM = new MenuVm();
            if(menus!=null && menus.Count > 0)
            {
                Menu menu = menus.First();
                menuVM.Description = menu.Description;
                menuVM.Id = menu.Id;
                menuVM.MenuName = menu.MenuName;
                menuVM.RestaurantId = menu.RestaurantId;
                menuVM.Statu = menu.Statu;
                if(menu.MenuItems!=null && menu.MenuItems.Count > 0)
                {
                    List<MenuItemVM> menuItemVMs = new List<MenuItemVM>();
                    foreach(MenuItem menuItem in menu.MenuItems)
                    {
                        MenuItemCategoryVM menuItemCategoryVM = new MenuItemCategoryVM();
                        menuItemCategoryVM.Id = menuItem.Category.Id;
                        menuItemCategoryVM.CategoryName = menuItem.Category.CategoryName;
                        MenuItemVM menuItemVM = new MenuItemVM();
                        menuItemVM.Category = menuItemCategoryVM;
                        menuItemVM.Id = menuItem.Id;
                        menuItemVM.MenuItemDescription = menuItem.MenuItemDescription;
                        menuItemVM.MenuItemIngredients = menuItem.MenuItemIngredients;
                        menuItemVM.MenuItemName = menuItem.MenuItemName;
                        menuItemVM.Price = menuItem.Price;
                        menuItemVMs.Add(menuItemVM);
                    }
                    menuVM.MenuItems = menuItemVMs;
                }
                return menuVM;
            }
            return null;

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
