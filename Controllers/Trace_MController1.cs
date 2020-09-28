using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Flying_Cow_TMSMVC.Controllers
{
    public class Trace_MController1 : Controller
    {
        /// <summary>
        /// 显示跟踪列表
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MapZg(int Id)
        {
            ViewBag.Id = Id;
            return View();
        }
    }
}
