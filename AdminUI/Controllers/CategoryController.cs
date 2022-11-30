using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntitiesLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AdminUI.Controllers
{
    public class CategoryController : Controller
    {
        ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult ListCategory()
        {
            //Id li getiren list methodumuz.
            var result = _categoryService.GetAll();
            return View(result);

        }
        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            _categoryService.Add(category);
            return RedirectToAction("ListCategory", "Category");
        }
        [HttpGet]
        //public IActionResult DeleteCategory()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult DeleteCategory(Category category)
        //{
        //    _categoryService.Delete(category);
        //    return View();
        //}
        [HttpGet]
        public IActionResult UpdateCategory(int id)
        {
            using (Context context = new Context())
            {
                var result = context.Categories.FirstOrDefault(x => x.CategoryId == id);
                return View(result);
            }

        }
        [HttpPost]
        public IActionResult UpdateCategory(Category category)
        {
            _categoryService.Update(category);
            return RedirectToAction("ListCategory", "Category");
        }
        [HttpGet]
        public IActionResult DeleteProductById(int id)

        {
            var ent = _categoryService.GetId(id);
            _categoryService.Delete(ent);
            return RedirectToAction("ListCategory", "Category");

        }
    }
}
