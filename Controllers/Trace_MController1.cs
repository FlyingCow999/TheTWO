using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Flying_Cow_TMSMVC.Controllers
{
    public class Trace_MController1 : Controller
    {
        private readonly IConfiguration _configuration;
        public Trace_MController1(IConfiguration configuration)
        {
            this._configuration = configuration;
        }
        /// <summary>
        /// 显示跟踪列表
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            string url = _configuration["apiUrl"];
            ViewBag.url = url;
            return View();
        }
        public IActionResult MapZg(int Id)
        {
            ViewBag.Id = Id;
            return View();
        }
    }
}
