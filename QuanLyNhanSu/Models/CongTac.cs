using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuanLyNhanSu.Models
{
    [Table("Congtacs")]
    public class CongTac
    {
        [Key]
        public int MaNV { get; set; }
        public string Ngay { get; set; }
        public string Congviec { get; set; }
        public string Chucvu { get; set; }
        public string Phongban { get; set; }
        public string Noilamviec { get; set; }
    }
}