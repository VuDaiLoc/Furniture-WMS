using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Furniture_WMS.Models
{
    public class DonHang
    {
        [Key]
        public int MaDonHang { get; set; }

        public int MaNguoiDung { get; set; }

        [ForeignKey("MaNguoiDung")]
        public NguoiDung NguoiDung { get; set; }

        [Required]
        public decimal TongTien { get; set; }

        [Required]
        [MaxLength(50)]
        public string TrangThai { get; set; } = "Chờ xử lý";

        public DateTime NgayDatHang { get; set; } = DateTime.Now;
    }
}
