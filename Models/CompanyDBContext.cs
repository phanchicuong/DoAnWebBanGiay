using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace WebsiteBanGiay.Models
{
    public class CompanyBDContext : DbContext
    {
        public CompanyBDContext() : base("CS") { }
        public DbSet<sanpham> Sanphams { get; set; }
        public DbSet<chitiet> ChiTiets { get; set; }
        public DbSet<giohang> Giohangs { get; set; }
    }
}