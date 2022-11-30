using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntitiesLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AdminUI.Controllers
{
    public class ProductController : Controller
    {
        IProductService _productService;
        public ProductController( IProductService productService )
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ListProductWithDetail()
        {
            //İstediğimiz veriyi cekebildiğimiz hali.
            var result = _productService.GetProductDetails();
            return View(result);

        }

        [HttpGet]
        public IActionResult ListProduct()
        {
            //Id li getiren list methodumuz.
            var result = _productService.GetListWithCategory();
            return View(result);

        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            _productService.Add(product);
            return RedirectToAction("ListProduct","Product");
        }
        [HttpGet]
        //public IActionResult DeleteProduct()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult DeleteProduct(Product product)
        //{
        //    _productService.Delete(product);
        //    return View();
        //}
        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            using (Context context = new Context())
            {
                var result = context.Products.FirstOrDefault(x => x.ProductId == id);
                return View(result);
            }

        }
        [HttpPost]
        public IActionResult UpdateProduct(Product product)
        {
            _productService.Update(product);
            return RedirectToAction("ListProduct","Product");
        }
        [HttpGet]
        public IActionResult DeleteProductById(int id)

        {
            var ent = _productService.GetId(id);
            _productService.Delete(ent);
            return RedirectToAction("ListProduct","Product");

        }
    }
}
