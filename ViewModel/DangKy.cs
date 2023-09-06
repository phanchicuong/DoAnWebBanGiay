using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace WebsiteBanGiay.ViewModel
{
    public class DangKy
    {
        [Key]
        [Required(ErrorMessage = "Bạn Cần Nhập UserName")]
        [RegularExpression("^([a-zA-Z0-9ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ\\s]+)$", ErrorMessage = "Không Được Nhập Ký Tự Đặt Biệt")]
       
        public string UserName { get; set; }

        [MinLength(4, ErrorMessage = "Trên 8 Ký Tự")]
        [Required(ErrorMessage = "Bạn Cần Nhập Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Bạn Cần Nhập ConfirmPassword")]
        [Compare("Password", ErrorMessage = "Không Giống Password")]
        public string ConfirmPassword { get; set; }

        [EmailAddress(ErrorMessage = "Định Dạng Chưa Đúng")]
        [Required(ErrorMessage = "Bạn Cần Nhập Email")]
        public string Email { get; set; }


        public string Phone { get; set; }
        public DateTime? SinhNhat { get; set; }
        public string DiaChi { get; set; }
        public string ThanhPho { get; set; }
        public string Anh { get; set; }
    }
}