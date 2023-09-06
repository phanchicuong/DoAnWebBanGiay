using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebsiteBanGiay.ViewModel
{
    public class LogIn
    {
        [Key]
        [Required(ErrorMessage = "Bạn Cần Nhập UserName")]
        public string UserName { get; set; }

        [MinLength(4, ErrorMessage = "Trên 8 Ký Tự")]
        [Required(ErrorMessage = "Bạn Cần Nhập Password")]
        public string Password { get; set; }
    }
}