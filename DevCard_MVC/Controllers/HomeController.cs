using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Diagnostics;

namespace DevCard_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Service> _services = new List<Service>()
        {
            new Service(1,"طلایی"),
            new Service(2,"نقره ای"),
            new Service(3,"برنزه ای"),
            new Service(4,"الماسی")
        };

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            Contact model = new Contact()
            {
                Services = new SelectList(_services, "Id", "Name")
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Contact(Contact model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.error = "اطلاعات وارد شده صحیح نمی باشد";
                model.Services = new SelectList(_services, "Id", "Name");
                return View(model);
            }
            ViewBag.success = "پیغام شما با موفقیت ارسال شد";
            ModelState.Clear();
            model = new Contact();
            model.Services = new SelectList(_services, "Id", "Name");
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
