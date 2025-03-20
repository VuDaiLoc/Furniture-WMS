using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Furniture_WMS.Models
{
    public class ChiTietDonHang
    {
        [Key]
        public int MaChiTietDonHang { get; set; }

        public int MaDonHang { get; set; }

        [ForeignKey("MaDonHang")]
        public DonHang DonHang { get; set; }

        public int MaSanPham { get; set; }

        [ForeignKey("MaSanPham")]
        public SanPham SanPham { get; set; }

        [Required]
        public int SoLuong { get; set; }

        [Required]
        public decimal Gia { get; set; }
    }
}
