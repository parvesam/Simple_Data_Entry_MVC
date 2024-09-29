using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BorrowEquipmentApp.Models;

namespace FastEquipmentTool.Controllers;

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

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public IActionResult RequestForm()
    {
        return View();
    }

    [HttpPost]
    public IActionResult SubmitRequest(RequestModel request)
    {
        if (ModelState.IsValid)
        {
            // Save the request using a repository pattern
            // Redirect to Confirmation Page
            return RedirectToAction("Confirmation");
        }
        return View(request); // If invalid, return to the form with validation errors
    }

    public IActionResult Confirmation()
    {
        return View();
    }

    public IActionResult AllEquipment()
    {
        // Sample data for demonstration; replace with your actual data retrieval logic
        var equipmentList = new List<EquipmentModel>
        {
            new EquipmentModel { Id = 1, Type = "Laptop", Description = "Dell XPS 13", Availability = true },
            new EquipmentModel { Id = 2, Type = "Phone", Description = "iPhone 12", Availability = false },
            // Add more equipment items here
        };

        return View(equipmentList);
    }

    public IActionResult AvailableEquipment()
    {
        // Sample data for demonstration; replace with your actual data retrieval logic
        var equipmentList = new List<EquipmentModel>
        {
            new EquipmentModel { Id = 1, Type = "Laptop", Description = "Dell XPS 13", Availability = true },
            new EquipmentModel { Id = 2, Type = "Phone", Description = "iPhone 12", Availability = false },
            new EquipmentModel { Id = 3, Type = "Tablet", Description = "iPad Pro", Availability = true },
            // Add more equipment items here
        };

        return View(equipmentList);
    }

    public IActionResult Requests()
    {
        // Sample data for demonstration; replace with your actual data retrieval logic
        var requests = new List<RequestModel>
        {
            new RequestModel { EquipmentType = "Laptop", Name = "John Doe", Role = "Student" },
            new RequestModel { EquipmentType = "Tablet", Name = "Jane Smith", Role = "Professor" },
            // Add more requests here
        };

        return View(requests);
    }




}
