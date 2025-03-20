using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Furniture_WMS.Models
{
    public class KhachHang
    {
        [Key]
        public int MaKhachHang { get; set; }

        public int MaNguoiDung { get; set; }

        [ForeignKey("MaNguoiDung")]
        public NguoiDung NguoiDung { get; set; }

        [Required]
        [MaxLength(20)]
        public string SoDienThoai { get; set; }

        [Required]
        [MaxLength(255)]
        public string DiaChi { get; set; }

        public DateTime NgayTao { get; set; } = DateTime.Now;
    }
}
