using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuanLyNhanSu.Models
{
    [Table("ThanNhans")]
    public class ThanNhan
    {
        [Key]
        public int MaNV { get; set; }
        public string Moiquanhe { get; set; }
        public string Ngaynghi { get; set; }
        public string HoTen { get; set; }
        public string Noidung { get; set; }
    }
}