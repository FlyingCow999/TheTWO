using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Flying_Cow_TMSMVC.Controllers
{
    public class _InquiryController : Controller
    {
        //询价单显示
        public IActionResult Index()
        {
            return View();
        }
        //询价单转订单
        public IActionResult addd()
        {
            return View();
        }
        //订单显示
        public IActionResult ddxs()
        {
            return View();
        }
        //下订单（已审核）
        public IActionResult xdd()
        {
            return View();
        }
        public IActionResult cg1()
        {
            return View();
        }
        
        public IActionResult CKAdd()
        {
            return View();
        }
    }
}
