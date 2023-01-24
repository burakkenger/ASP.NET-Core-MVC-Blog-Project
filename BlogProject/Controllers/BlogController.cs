using BusinessLayer.Concrete;
using DataAccesLayer.EnitiyFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class BlogController : Controller
    {
        BlogManager blogManager = new BlogManager(new EfBlogRepository());
        CommentManager commentManager = new CommentManager(new EfCommentRepository());
        public IActionResult Index()
        {
            var values = blogManager.GetBlogListIncludeCategory();
            return View(values);
        }

        public IActionResult BlogReadAll(int ID)
        {
            ViewBag.VbBlogID = ID;
            var value = blogManager.GetBlogByID(ID);
            //ViewBag.VbBlogProps = blogManager.GetBlogByID(ID); // Return icinde modele deger yollamadan da bu sekile Viewbag icinde degerleri yollayip listeletebiliyoruz bir sayfada 2 model kullanimi gerekirse bu sekilde yapilabilir
            return View(value);
        }

        [HttpGet]
        public IActionResult AddComment()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddComment(Comment data)
        {
            data.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            data.Status = true;
            commentManager.AddComment(data);
            var blogIndex = data.BlogID;
            return RedirectToAction("BlogReadAll", "Blog", new {ID = blogIndex});
        }
    }
}
