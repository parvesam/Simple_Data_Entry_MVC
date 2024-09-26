using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BorrowEquipmentApp.Models;
using System.Collections.Generic; // Ensure you have this using directive

namespace BorrowEquipmentApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SubmitRequest(RequestModel request)
        {
            return RedirectToAction("Confirmation");
        }

        public IActionResult Requests()
        {
            var requestList = new List<RequestModel>
            {
                new RequestModel { Id = 1, EquipmentType = "Laptop", Description = "Request for Dell XPS 13", RequestDate = DateTime.Now },
                new RequestModel { Id = 2, EquipmentType = "Tablet", Description = "Request for iPad Pro", RequestDate = DateTime.Now }
                // Add more requests as needed
            };

            return View(requestList);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult AllEquipment()
        {
            var equipmentList = GetEquipmentList();
            return View(equipmentList);
        }

        private List<Equipment> GetEquipmentList()
        {
            // Example implementation to get the list of equipment
            return new List<Equipment>
            {
                new Equipment { Id = 1, Type = "Laptop", Description = "Dell XPS 13", IsAvailable = true },
                new Equipment { Id = 2, Type = "Tablet", Description = "iPad Pro", IsAvailable = true },
                // Add more equipment items as needed
            };
        }

    }
}
