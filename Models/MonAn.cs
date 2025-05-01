using System.ComponentModel.DataAnnotations;

namespace RMS.Models

{
    public class MonAn
    {
        [Key]
        public int MonAnId { get; set; }
        public string? TenMonAn { get; set; }
        public string? MoTa { get; set; }
        public decimal Gia { get; set; }
        public string? HinhAnh { get; set; }
        public string? DanhMuc { get; set; } // Ví dụ: món chính, món tráng miệng, đồ uống, v.v.

    }    
}
