using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccesLayer.EnitiyFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager writerManager = new WriterManager(new EfWriterRepository());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Writer writer)
        {
            WriterValidator validator = new WriterValidator();
            ValidationResult result = validator.Validate(writer);

            if (result.IsValid)
            {
                writer.Status = true;
                writer.About = "Deneme Test";
                writerManager.WriterAdd(writer);
                return RedirectToAction("Index", "Blog");
            }
            else
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
        }
    }
}
