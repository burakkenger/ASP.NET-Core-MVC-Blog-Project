using BusinessLayer.Concrete;
using DataAccesLayer.EnitiyFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class ContactController : Controller
    {
        ContactManager contactManager = new ContactManager(new EfContactRepository());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Contact data)
        {
            data.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            data.Status = true;
            contactManager.Add(data);

            return RedirectToAction("Index", "Blog");
        }
    }
}
