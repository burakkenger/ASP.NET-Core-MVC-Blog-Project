using BusinessLayer.Concrete;
using DataAccesLayer.EnitiyFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.VıewComponents.Blog
{
    public class WriterLastBlogs: ViewComponent
    {
        BlogManager blogManager = new BlogManager(new EfBlogRepository());

        public IViewComponentResult Invoke(int ID)
        {
            var values = blogManager.GetBlogListByWriter(ID);
            return View(values);
        }
    }
}
