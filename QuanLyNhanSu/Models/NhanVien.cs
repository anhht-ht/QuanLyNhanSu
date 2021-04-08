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
        public int MaNV { get; set; }
        public int MaChucVu { get; set; }
        public string HoTen { get; set; }
        public string Gioitinh { get; set; }
        public string NgaySinh { get; set; }
        public string QueQuan { get; set; }
        public string DanToc { get; set; }
        public string ChungMinhThu { get; set; }
        public string Ma_PhongBan { get; set; }
    }
}