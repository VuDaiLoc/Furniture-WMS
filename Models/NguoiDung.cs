using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Furniture_WMS.Models
{
    public class NguoiDung
    {
        [Key]
        public int MaNguoiDung { get; set; }

        [Required]
        public string HoTen { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required]
        public string MatKhau { get; set; }  // Chuyển về string thay vì byte[]

        public int MaVaiTro { get; set; } // 1 = Admin, 2 = User

        public DateTime NgayTao { get; set; } = DateTime.Now;
    }
}
