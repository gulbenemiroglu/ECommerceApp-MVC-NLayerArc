using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using PresentationUI.Models;
using PresentationUI.Services;

namespace PresentationUI.Controllers
{
    public class CartController : Controller
    {
        private ICartSessionService _cartSessionService;
        private ICartService _cartService;
        private IProductService _productService;
        public CartController(ICartSessionService cartSessionService, ICartService cartService, IProductService productService)
        {
            _cartSessionService = cartSessionService;
            _cartService = cartService;
            _productService = productService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SepeteEkle(int productId)
        {
            //HttpContext.Session.SetString("city", "Ankara");  Bunları burda yazarsak test edilebilirlik   olmaz.

            //HttpContext.Session.GetString("city");
            //HttpContext.Session.GetInt32("age");

            var productToBeAdded = _productService.GetId(productId);
            var cart = _cartSessionService.GetCart();
            _cartService.AddToCart(cart, productToBeAdded); //cart nesnesine ürün eklemek istiyorum.
            _cartSessionService.SetCart(cart);//Ekledikten sonra da yine sessiona atmamız gerekiyor.
            /* TempData.Add("message", string.Format("{0} was succesfully added to the cart!", productToBeAdded.ProductName)); *///tempdata tek bir requestlik veri taşır genelde mesaj verme de kullanılır
            return RedirectToAction("Index", "Home");

        }
        public IActionResult List()
        {
            var cart = _cartSessionService.GetCart();
            CartSummaryViewModel cartSummaryViewModel = new CartSummaryViewModel
            {
                Cart = cart
            };
            return View(cartSummaryViewModel);
        }
        public IActionResult SepettenSil(int productId)
        {
            var cart = _cartSessionService.GetCart();
            _cartService.RemoveFromCart(cart, productId);
            _cartSessionService.SetCart(cart);
            TempData.Add("message", string.Format("Your product was succesfully removed from cart!"));
            return RedirectToAction("List", "Cart");
        }
    }
}
