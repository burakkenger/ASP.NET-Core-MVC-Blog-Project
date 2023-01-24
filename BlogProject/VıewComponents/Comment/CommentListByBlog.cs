using BusinessLayer.Concrete;
using DataAccesLayer.EnitiyFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.VıewComponents.Comment
{
    public class CommentListByBlog : ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EfCommentRepository());
        public IViewComponentResult Invoke(int ID)
        {
            var values = commentManager.GetAll(ID);

            return View(values);
        }
    }
}
