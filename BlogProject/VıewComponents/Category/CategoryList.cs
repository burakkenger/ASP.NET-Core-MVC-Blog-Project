using BusinessLayer.Concrete;
using DataAccesLayer.EnitiyFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.VıewComponents.Category
{
    public class CategoryList : ViewComponent
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());

        public IViewComponentResult Invoke()
        {
            var values = categoryManager.GetAll();
            return View(values);
        }
    }
}
