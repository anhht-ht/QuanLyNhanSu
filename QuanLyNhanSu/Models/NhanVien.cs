using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuanLyNhanSu.Models
{
    [Table("NhanViens")]
    public class NhanVien
    {
        [Key]
        public int id { get; set; }
        [Required, MaxLength(30)]
        public string name { get; set; }
        [Required, MinLength(10),MaxLength(14)]
        public string phone { get; set; }
        public string gioitinh { get; set; }
        public string address { get; set; }
    }
}