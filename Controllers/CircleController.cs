using baiTapTuan3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace baiTapTuan3.Controllers
{
    public class CircleController : Controller
    {
        // GET: Circle
        [HttpGet]
        public ActionResult Index()
        {

            return View();
        }
        [ValidateAntiForgeryToken]

        [HttpPost]
        public ActionResult Index(Circle c)
        {
            if (c.BanKinh > 0)
            {
                ViewBag.TinNhan1 = "Với bán kính là " + c.BanKinh + " thì diện tích hình tròn là: " + c.DienTich();
                ViewBag.TinNhan2 = "Với bán kính là " + c.BanKinh + " thì chu vi hình tròn là: " + c.ChuVi();
            }
            else
            {
                ViewBag.TinNhan3 = "Bán kính không được rỗng hoặc <= 0";
            };
            return View(c);
        }
    }
}