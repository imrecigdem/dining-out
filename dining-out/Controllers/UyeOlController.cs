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
    public class UyeOlController : Controller
    {
        private readonly ILogger<UyeOlController> _logger;

        public UyeOlController(ILogger<UyeOlController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index(string kullaniciTipi)
        {
            return View("Index");
        }



    }
}
