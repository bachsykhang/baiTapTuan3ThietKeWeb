using baiTapTuan3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace baiTapTuan3.Controllers
{
    public class RectangleController : Controller
    {
        // GET: Rectangle
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index (Rectangle r)
        {
            if (r.ChieuDai <=0 || r.ChieuRong <= 0)
            {
                ViewBag.ThongBao1 = "Giá trị truyền vào không được nhỏ hơn hoặc bằng 0";
            }else
            {
                ViewBag.ThongBao2 = "Với chiều dài là " + r.ChieuDai + " và chiều rộng là " + r.ChieuRong +
                    " thì chu vi hình chữ nhật là: " + r.ChuViHCN();
                ViewBag.ThongBao3 = "Với chiều dài là " + r.ChieuDai + " và chiều rộng là " + r.ChieuRong +
                    " thì diện tích hình chữ nhật là: " + r.DienTichHCN();
            }
            return View(r);
        }
    }
}