using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Flying_Cow_TMSMVC.Controllers
{
    public class AnomalyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ChuLi(int id)
        {
            ViewBag.id = id;
            return View();
        }
    }
}
