using Microsoft.AspNetCore.Mvc;

namespace InventoryTracker.Controllers
{
    public class InventoryTrackerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
