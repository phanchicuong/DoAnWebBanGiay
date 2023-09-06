using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;
namespace WebsiteBanGiay.Identity
{
    public class AppUser : IdentityUser
    {
        public DateTime? SinhNhat { get; set; }
        public string DiaChi { get; set; }
        public string ThanhPho { get; set; }
        public string Anh { get; set; }
    }
}