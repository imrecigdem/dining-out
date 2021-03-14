using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using dining_out.Models.ViewModels;
using dining_out.Models.DbModels;


namespace dining_out.Utility
{
    public class StaticDataManagerUtility
    {
        public static List<KeyValueVM> kisiSayisiListesi() {
            List<KeyValueVM> kisiler = new List<KeyValueVM>();
            for (int i = 1; i <= 20; ++i)
            {
                kisiler.Add(new KeyValueVM(i.ToString(), i.ToString()));
            }
            return kisiler;
        }
      
    }
}
