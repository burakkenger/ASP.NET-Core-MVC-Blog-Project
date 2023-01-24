using BusinessLayer.Concrete;
using DataAccesLayer.EnitiyFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutRepository());
        public IActionResult Index()
        {
            var values = aboutManager.GetAll();
            return View(values);
        }
    }
}
