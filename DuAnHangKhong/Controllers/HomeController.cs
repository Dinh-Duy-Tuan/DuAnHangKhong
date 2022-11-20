using DuAnHangKhong.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DuAnHangKhong.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View(LichChuyenBay.listChuyenBay);
        }

        public ActionResult ThemMoiChuyenBay()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LuuThemMoiChuyenBay(string flightNo, DateTime ngay, string diemDi, string diemDen)
        {
            //xử lý lưu
            LichChuyenBay.listChuyenBay.Add(new ChuyenBay()
            {
                FlightNo = flightNo,
                Ngay = ngay,
                DiemDi = diemDi,
                DiemDen = diemDen,
            });
            return RedirectToAction("Index");
        }
    }
}