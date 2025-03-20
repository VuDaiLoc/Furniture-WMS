using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Furniture_WMS.Models
{
    public class KhoHang
    {
        [Key]
        public int MaKho { get; set; }

        public int MaSanPham { get; set; }

        [ForeignKey("MaSanPham")]
        public SanPham SanPham { get; set; }

        public int SoLuongNhap { get; set; } = 0;

        public int SoLuongXuat { get; set; } = 0;

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int TonKho { get; private set; }
    }
}
