using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuanLyNhanSu.Models
{
    [Table("DuAns")]
    public class DuAn
    {
        [Key]
        public int MaDuAN { get; set; }
        public string TenDuAn { get; set; }
        public String NgayBatDau { get; set; }
        public String NgayKetThuc { get; set; }
        public String SoLuong { get; set; }
        public String DonGia { get; set; }
        public String ChietKhau { get; set; }
    }
}