using baiTapTuan3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace baiTapTuan3.Controllers
{
    public class TriangleController : Controller
    {
        // GET: Triangle
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [ValidateAntiForgeryToken]

        [HttpPost]
        public ActionResult Index(Triangle t)
        {
            if(t.isTamGiac())
            {
                ViewBag.ThongBao1 = "Với giá trị là: " + t.CanhThu1 + "," + t.CanhThu2 + "," + t.CanhThu3 +
                    " thì chu vi hình tam giác là: " + t.ChuViTamGiac();
                ViewBag.ThongBao2 = "Với giá trị là: " + t.CanhThu1 + "," + t.CanhThu2 + "," + t.CanhThu3 +
                    " thì diện tích hình tam giác là: " + t.DienTichTamGiac();
            }else
            {
                ViewBag.ThongBao3 = "Gía trị bạn nhập không phải là hình tam giác.";
            }
            return View(t);
        }
    }
}