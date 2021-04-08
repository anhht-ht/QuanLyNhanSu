using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuanLyNhanSu.Models
{
    [Table("Chitietnghiviecs")]
    public class ChiTietNghiViec
    {
        [Key]
        public int MaNV { get; set; }
        public string Manghiviec { get; set; }
        public string Ngaynghi { get; set; }
        public string Thoigiannghi { get; set; }
    }
}