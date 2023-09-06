using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebsiteBanGiay.Models
{
    public class giohang
    {
        [Key]
        public string NameID { get; set; }
        public string TenSP { get; set; }
        public string Anh { get; set; }
        public int SoLuong { get; set; }
        public float Dongia { get; set; }

        public virtual sanpham sanpham { get; set; }
        public virtual chitiet chitiet { get; set; }
    }
}