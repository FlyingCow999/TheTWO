using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Flying_Cow_TMSMVC.Controllers
{
    public class Inquiry_MController : Controller
    {
        /// <summary>
        /// 显示询价列表
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 审核页面
        /// </summary>
        /// <returns></returns>
        public IActionResult ShenHe(int Id)
        {
            ViewBag.Id = Id;
            return View();
        }
        /// <summary>
        /// 询价处理页面
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public IActionResult XJ_Deal(int Id)
        {
            ViewBag.Id = Id;
            return View();
        }
        /// <summary>
        /// 确认报价页面
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public IActionResult Confirm_quotation(int Id)
        {
            ViewBag.Id = Id;
            return View();
        }
        
    }
}
