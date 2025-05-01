using System.ComponentModel.DataAnnotations;

namespace RMS.Models
{
    public class KhachHang
    {
        [Key]
        public int KhachhangId { get; set; }
        public string? HoTen { get; set; }
        public string? DiaChi { get; set; }
        public string? SoDienThoai { get; set; }
        public DateTime NgaySinh { get; set; }
    }
}