using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Flying_Cow_TMSMVC.Controllers
{
    public class UserAddController : Controller
    {
        public IActionResult Login1()
        {
            return View();
        }
        //public IActionResult ShouIndex1(string name) //主页
        //{
        //    ViewBag.ss = name;
        //    return View();
        //}
        public IActionResult ShouIndex(string name) //主页
        {
            ViewBag.ss = name;
            return View();
        }
        public IActionResult enroll()
        {
            return View();
        }
    }
}
