using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RMS.Models;

namespace RMS.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {

    }
    public DbSet<NhanVien> NhanVien { get; set; }
    public DbSet<KhachHang> KhachHang { get; set; }
    public DbSet<MonAn> MonAn { get; set; }
}
