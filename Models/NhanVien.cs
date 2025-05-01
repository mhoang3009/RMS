using System.ComponentModel.DataAnnotations;

namespace RMS.Models
{
    public class NhanVien
    {
        [Key]
        public int NhanVienId { get; set; }
        public string? HoTen { get; set; }
        public string? DiaChi { get; set; }
        public string? SoDienThoai { get; set; }
        public DateTime NgaySinh { get; set; }
        public string? ChucVu { get; set; }
    }
}   