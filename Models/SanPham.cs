using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Furniture_WMS.Models
{
    public class SanPham
    {
        [Key]
        public int MaSanPham { get; set; }

        public int MaDanhMuc { get; set; }

        [ForeignKey("MaDanhMuc")]
        public DanhMucSanPham DanhMucSanPham { get; set; }

        [Required]
        [MaxLength(100)]
        public string TenSanPham { get; set; }

        public string MoTa { get; set; }

        [Required]
        public decimal Gia { get; set; }

        [Required]
        public int SoLuong { get; set; }

        public string HinhAnh { get; set; }

        public DateTime NgayTao { get; set; } = DateTime.Now;
    }
}
