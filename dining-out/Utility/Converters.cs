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
            restaurantVM.CoverImg = restaurant.CoverImg;
            restaurantVM.Logo = restaurant.Logo;
            restaurantVM.Desc = restaurant.Desc;
            restaurantVM.District = restaurant.District;
            restaurantVM.Id = restaurant.Id;
            restaurantVM.Name = restaurant.Name;
            restaurantVM.SystemDefinitionName = restaurant.SystemDefinitionName;
            restaurantVM.UserId = restaurant.UserId;

            List<BookTableRezervation> bookTableRezervations = restaurant.BookTableRezervations.OrderBy(book => book.RezervationCreatedDatetime).ToList();
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

            if (bookTableRezervations != null && bookTableRezervations.Count > 0)
            {
                DateTime rezervationCreatedDatetime = bookTableRezervations[0].RezervationCreatedDatetime;
                TimeSpan difference = DateTime.Now - rezervationCreatedDatetime;
                restaurantVM.LastRezervationText = "Son rezervasyon " + difference.TotalMinutes + " dakika önce";
            }
            else
            {
                restaurantVM.LastRezervationText = "Henüz rezervasyon alınmamış.";
            }

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

        public static BookTableRezervationVM convertModel(BookTableRezervation bookTableRezervation)
        {
            BookTableRezervationVM rezervationVM = new BookTableRezervationVM();
            rezervationVM.AttendeeNumber = bookTableRezervation.AttendeeNumber;
            rezervationVM.Description = bookTableRezervation.Description;
            rezervationVM.Email = bookTableRezervation.Email;
            rezervationVM.Id = bookTableRezervation.Id;
            rezervationVM.NameLastname = bookTableRezervation.NameLastname;
            rezervationVM.PhoneNumber = bookTableRezervation.PhoneNumber;
            rezervationVM.RestaurantName = bookTableRezervation.Restaurant.Name;
            rezervationVM.RezervationCreatedDatetime = bookTableRezervation.RezervationCreatedDatetime;
            rezervationVM.RezervationDate = bookTableRezervation.RezervationDate.Date.ToShortDateString();
            rezervationVM.RezervationTime = bookTableRezervation.RezervationTime.ToString(@"hh\:mm");
            rezervationVM.RezervationStatus = ConstantUtility.textValueOfRezervationStatus(bookTableRezervation.RezervationStatus);
            rezervationVM.RezervationDbStatus = bookTableRezervation.RezervationStatus;
            rezervationVM.RezervationUserName = bookTableRezervation.RezervationUser.Name + " " + bookTableRezervation.RezervationUser.Surname;
            if(bookTableRezervation.BookTableAttendees!=null && bookTableRezervation.BookTableAttendees.Count > 0)
            {
                List<UserVM> attendees = new List<UserVM>();
                foreach (BookTableAttendee bookTableAttendee in bookTableRezervation.BookTableAttendees)
                {
                    if (bookTableAttendee.User != null)
                    {
                        UserVM userVM = convertModel(bookTableAttendee.User);
                        attendees.Add(userVM);
                    }
                }
                rezervationVM.Attendees = attendees;
            }

            return rezervationVM;
        }

        public static UserVM convertModel(User user)
        {
            UserVM userVM = new UserVM();
            userVM.Description = user.Description;
            userVM.Id = user.Id;
            userVM.Name = user.Name;
            userVM.Surname = user.Surname;
            userVM.UserName = user.UserName;
            userVM.UserType = user.UserType;
            return userVM;
        }

        public static BookTableOrderedItemVM convertModel(BookTableOrderedItem bookTableOrderedItem)
        {
            BookTableOrderedItemVM bookTableOrderedItemVM = new BookTableOrderedItemVM();
            bookTableOrderedItemVM.Id = bookTableOrderedItem.Id;
            bookTableOrderedItemVM.MenuItemId = bookTableOrderedItem.MenuItemId;
            bookTableOrderedItemVM.MenuItemName = bookTableOrderedItem.MenuItem.MenuItemName;
            bookTableOrderedItemVM.OrderedDate = String.Format("{0:g}", bookTableOrderedItem.OrderedDate);
            bookTableOrderedItemVM.Price = bookTableOrderedItem.MenuItem.Price;
            bookTableOrderedItemVM.RezervationId = bookTableOrderedItem.RezervationId;
            bookTableOrderedItemVM.Status = bookTableOrderedItem.Status;
            bookTableOrderedItemVM.StatusText = ConstantUtility.textValueOfOrderedItemStatus(bookTableOrderedItem.Status);
            bookTableOrderedItemVM.UserName = bookTableOrderedItem.User.UserName;
            return bookTableOrderedItemVM;
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
