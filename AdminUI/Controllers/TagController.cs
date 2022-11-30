using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntitiesLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AdminUI.Controllers
{
    public class TagController : Controller
    {
        ITagService _tagService;
        public TagController(ITagService tagService)
        {
            _tagService = tagService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ListTag()
        {
            //Id li getiren list methodumuz.
            var result = _tagService.GetAll();
            return View(result);

        }
        [HttpGet]
        public IActionResult AddTag()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddTag(Tag tag)
        {
            _tagService.Add(tag);
            return View();
        }
       // [HttpGet]
        //public IActionResult DeleteTag()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult DeleteTag(Tag tag)
        //{
        //    _tagService.Delete(tag);
        //    return View();
        //}
        [HttpGet]
        public IActionResult UpdateTag(int id)
        {
            using (Context context = new Context())
            {
                var result = context.Tags.FirstOrDefault(x => x.TagId == id);
                return View(result);
            }

        }
        [HttpPost]
        public IActionResult UpdateTag(Tag tag)
        {
            _tagService.Update(tag);
            return View();
        }
        [HttpGet]
        public IActionResult DeleteTagById(int id)

        {
            var ent = _tagService.GetId(id);
            _tagService.Delete(ent);
            return RedirectToAction("ListTag", "Tag");

        }
    }
}
