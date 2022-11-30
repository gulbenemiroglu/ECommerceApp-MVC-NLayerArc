using Microsoft.AspNetCore.Mvc;

namespace PresentUI.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
