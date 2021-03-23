using System;
using System.Collections.Generic;
using dining_out.Models.DbModels;

namespace dining_out.Models.ViewModels
{
    public class MenuVm
    {
      
        public MenuVm()
        {
            MenuItems = new HashSet<MenuItemVM>();
        }

        public int Id { get; set; }
        public string MenuName { get; set; }
        public string Description { get; set; }
        public string Statu { get; set; }

        public ICollection<MenuItemVM> MenuItems { get; set; }
    }
}
