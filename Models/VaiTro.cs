using System.ComponentModel.DataAnnotations;

namespace Furniture_WMS.Models
{
    public class VaiTro
    {
        [Key]
        public int MaVaiTro { get; set; }

        [Required]
        public string TenVaiTro { get; set; }
    }
}
