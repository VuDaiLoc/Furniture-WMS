using Microsoft.EntityFrameworkCore;
using Furniture_WMS.Models;

namespace Furniture_WMS.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<NguoiDung> NguoiDungs { get; set; } // Chỉnh lại Users thành NguoiDungs
        public DbSet<VaiTro> VaiTros { get; set; }
        public DbSet<DanhMucSanPham> DanhMucSanPhams { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<DonHang> DonHangs { get; set; }
        public DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }
        public DbSet<KhoHang> KhoHangs { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
    }
}
