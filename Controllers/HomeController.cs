using DreamClub.Data;
using DreamClub.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DreamClub.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly DreamClubContext _context;

        public HomeController(ILogger<HomeController> logger, DreamClubContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            TrialCustomer customer = new TrialCustomer();
            return View(customer);
        }       
        
        public ActionResult SaveCustomer(TrialCustomer trialCustomer)
        {
            _context.Add(trialCustomer);
            _context.SaveChanges();
            return PartialView("_Message", trialCustomer);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
