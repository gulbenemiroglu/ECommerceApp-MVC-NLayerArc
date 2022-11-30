using Microsoft.AspNetCore.Mvc;

namespace PresentUI.Models
{
    public class CartSummaryViewModel : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
