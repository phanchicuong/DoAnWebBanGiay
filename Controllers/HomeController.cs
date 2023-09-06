using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteBanGiay.Models;

namespace WebsiteBanGiay.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(int page = 1, string search = "")
        {
            CompanyBDContext db = new CompanyBDContext();
            List<chitiet> hang = db.ChiTiets.Where(row => row.TenSP.Contains(search)).ToList();
            ViewBag.Search = search;
            int BuocNhay = 8;/// 5 dong 1 rtnag
            int TInh = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(hang.Count) / Convert.ToDouble(BuocNhay)));///chia cho moi trng 
            int BuocNhaySkip = (page - 1) * BuocNhay;
            ViewBag.Page = page;
            ViewBag.tinh = TInh;
            hang = hang.Skip(BuocNhaySkip).Take(BuocNhay).ToList();
            return View(hang);
        }

        public ActionResult action()
        {
            CompanyBDContext db = new CompanyBDContext();
            List<giohang> gio = db.Giohangs.ToList();
            return View(gio);
        }
        public ActionResult Detail(int? id)
        {
            CompanyBDContext db = new CompanyBDContext();
            chitiet pro = db.ChiTiets.Where(row => row.MaLoai == id).FirstOrDefault();
            return View(pro);
        }
        public ActionResult Trangchu()
        {
            CompanyBDContext db = new CompanyBDContext();
            List<sanpham> gio1 = db.Sanphams.ToList();
            return View(gio1);
        }
    }
}