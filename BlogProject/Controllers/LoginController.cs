using BusinessLayer.Concrete;
using DataAccesLayer.EnitiyFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CoreDemo.Controllers
{
    public class LoginController : Controller
    {
        WriterManager writerManager = new WriterManager(new EfWriterRepository());

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Index(Writer writer)
        {
            var loginData = writerManager.Login(writer);
            
            if(loginData != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, loginData.Mail),
                };
                var userIdentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal); // şifreli olarak cookie oluşturması için
                
                return RedirectToAction("Index", "Writer");
            }
            else
                return View();
        }
    }
}
