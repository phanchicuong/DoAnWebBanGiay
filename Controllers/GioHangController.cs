using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteBanGiay.Models;

namespace WebsiteBanGiay.Controllers
{
    public class GioHangController : Controller
    {
        CompanyBDContext db = new CompanyBDContext();
        // GET: GioHang
        private const string CartSession = "CartSession";
        public ActionResult Index()
        {
            var cart = Session[CartSession];
            var list = new List<giohang>();
            if (cart != null)
            {
                list = (List<giohang>)cart;
            }
            return View(list);

        }
        public ActionResult AddItem(int productId, int SoLuong)
        {

            chitiet product = db.ChiTiets.FirstOrDefault(c => c.MaLoai == productId);
            var cart = Session[CartSession];
            if (cart != null)
            {
                var list = (List<giohang>)cart;
                if (list.Exists(x => x.chitiet.MaLoai == productId))
                {

                    foreach (var item in list)
                    {
                        if (item.chitiet.MaLoai == productId)
                        {
                            item.SoLuong = SoLuong;
                        }
                    }
                }
                else
                {
                    //tạo mới đối tượng giỏ hàng
                    var item = new giohang();
                    item.chitiet = product;
                    item.SoLuong = SoLuong;
                    list.Add(item);
                }
                //Gán vào session
                Session[CartSession] = list;
            }
            else
            {
                //tạo mới đối tượng cart item
                var item = new giohang();
                item.chitiet = product;
                item.SoLuong = SoLuong;
                var list = new List<giohang>();
                list.Add(item);
                //Gán vào session
                Session[CartSession] = list;
            }
            return RedirectToAction("Index");
        }

        //cap nhat gio hang
        public ActionResult Update(int id, int quantity)
        {
            chitiet product = db.ChiTiets.FirstOrDefault(c => c.MaLoai == id);
            var cart = Session[CartSession];
            if (cart != null)
            {
                var list = (List<giohang>)cart;
                if (list.Exists(x => x.chitiet.MaLoai == id))
                {

                    foreach (var item in list)
                    {
                        if (item.chitiet.MaLoai == id)
                        {
                            item.SoLuong = quantity;
                        }
                    }
                }
            }
            return RedirectToAction("Index");
        }
    }
}