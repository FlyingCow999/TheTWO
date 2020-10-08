using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Flying_Cow_TMSMVC.Controllers
{
    public class YunSunController : Controller
    {
        //订单管理
        public IActionResult Indexdjgl()
        {

            return View();
        }
        //处理订单
        public IActionResult Indexcldj(string id,int eid)
        {   
            ViewBag.Id = id;
            ViewBag.eid = eid;
            return View();
        }
        //上传提货单
        public IActionResult Add()
        {
            return View();
        }
        //上传提货单
        public IActionResult dcthd(string id)
        {
            ViewBag.Id = id;
            return View();
        }
        //图片
        //public IActionResult img()
        //{
        //    return View();
        //}

        //报价管理-待报价订单
        public IActionResult dbjdd()
        {
            
            return View();
        }
        //报价管理-订单报价
        public IActionResult ddbj(string Id)
        {
            ViewBag.eid = Id;
            return View();
        }
        public IActionResult Show()
        {
            return View();
        }
        public IActionResult Add(string name)
        {
            ViewBag.name = name;
            return View();
        }
    }
}
