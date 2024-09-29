using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BorrowEquipmentApp.Models;

namespace BorrowEquipmentApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        // In-memory list to store requests
        private static List<RequestModel> _requests = new List<RequestModel>();

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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // GET: RequestForm
        public IActionResult RequestForm()
        {
            return View();
        }

        // POST: SubmitRequest
        [HttpPost]
        public IActionResult SubmitRequest(RequestModel request)
        {
            if (ModelState.IsValid)
            {
                // Add the submitted request to the in-memory list
                _requests.Add(request);

                // Redirect to the confirmation page after submitting the request
                return RedirectToAction("Confirmation");
            }

            // If the model is invalid, return to the form with validation errors
            return View(request);
        }

        // GET: Confirmation
        public IActionResult Confirmation()
        {
            return View();
        }

        // GET: AllEquipment
        public IActionResult AllEquipment()
        {
            // Sample data for demonstration; replace with actual data retrieval logic
            var equipmentList = new List<EquipmentModel>
            {
                new EquipmentModel { Id = 1, Type = "Laptop", Description = "Dell XPS 13", Availability = true },
                new EquipmentModel { Id = 2, Type = "Phone", Description = "iPhone 12", Availability = false },
                // Add more equipment items here
            };

            return View(equipmentList);
        }

        // GET: AvailableEquipment
        public IActionResult AvailableEquipment()
        {
            // Sample data for demonstration; replace with actual data retrieval logic
            var equipmentList = new List<EquipmentModel>
            {
                new EquipmentModel { Id = 1, Type = "Laptop", Description = "Dell XPS 13", Availability = true },
                new EquipmentModel { Id = 2, Type = "Phone", Description = "iPhone 12", Availability = false },
                new EquipmentModel { Id = 3, Type = "Tablet", Description = "iPad Pro", Availability = true },
                // Add more equipment items here
            };

            return View(equipmentList);
        }

        // GET: Requests (Admin Page for Viewing Requests)
        public IActionResult Requests()
        {
            // Pass the stored requests to the view
            return View(_requests);
        }
    }
}
