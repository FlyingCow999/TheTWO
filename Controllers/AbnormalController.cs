using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Flying_Cow_TMSMVC.Controllers
{
    public class AbnormalController : Controller
    {
        public IActionResult show()
        {
            return View();
        }
        public IActionResult detail(int id)
        {
            ViewBag.id = id;
            return View();
        }
    }
}
