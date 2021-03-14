﻿using System;
using System.Collections.Generic;

#nullable disable

namespace dining_out.Models.DbModels
{
    public partial class User
    {
        public User()
        {
            Restaurants = new HashSet<Restaurant>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserType { get; set; }

        public virtual ICollection<Restaurant> Restaurants { get; set; }
    }
}