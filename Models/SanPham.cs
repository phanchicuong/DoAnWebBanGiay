using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebsiteBanGiay.Models
{
    public class sanpham
    {
        [Key]
        public int MaSP { get; set; }
        public string Ten { get; set; }
        public string anh { get; set; }
    }
}