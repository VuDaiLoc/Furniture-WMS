using System;
using System.ComponentModel.DataAnnotations;

namespace Furniture_WMS.Models
{
    public class DanhMucSanPham
    {
        [Key]
        public int MaDanhMuc { get; set; }

        [Required]
        public string TenDanhMuc { get; set; }

        public string MoTa { get; set; }

        public DateTime NgayTao { get; set; } = DateTime.Now;
    }
}
