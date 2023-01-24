using BusinessLayer.Concrete;
using DataAccesLayer.EnitiyFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Newtonsoft.Json;

namespace CoreDemo.Controllers
{
    public class NewsLetterController : Controller
    {
        NewsLetterManager newsletterManager = new NewsLetterManager(new EfNewsLetterRepository());
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SubscribeMail()
        {
            return View();
        }

        /*[HttpPost]
        public IActionResult SubscribeMail(NewsLetter data)
        {
            data.Status = true;
            newsletterManager.AddNewsLetter(data);

            return RedirectToAction("Index", "Blog");
        }*/

        [HttpPost]
        public JsonResult postSubscribeMail(NewsLetter data)
        {
            newsletterManager.AddNewsLetter(data);
            var jsonNewsLetter = JsonConvert.SerializeObject(data);

            return Json(jsonNewsLetter);
        }
    }
}
