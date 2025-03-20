using Furniture_WMS.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// 🔹 Cấu hình kết nối SQL Server
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

// 🔹 Cấu hình Session
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

// 🔹 Thêm dịch vụ MVC
builder.Services.AddControllersWithViews();

// 🔹 Cấu hình quyền truy cập (Authentication/Authorization) nếu cần
builder.Services.AddAuthentication();
builder.Services.AddAuthorization();

var app = builder.Build();

// 🔹 Cấu hình xử lý lỗi cho môi trường sản xuất
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

// 🔹 Cấu hình Middleware
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseSession();  // 🔥 Quan trọng: Bật Session ở đây!
app.UseAuthentication(); // Nếu có đăng nhập
app.UseAuthorization();

// 🔹 Định tuyến mặc định (Mở trang Login trước)
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.UseStaticFiles();

app.Run();
