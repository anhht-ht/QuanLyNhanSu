using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuanLyNhanSu.Models
{
    [Table("ChuyenPhongs")]
    public class ChuyenPhong
    {
        [Key]
        public int MaNV { get; set; }
        public string Ma_phongban { get; set; }
        public string NgayChuyen { get; set; }

    }
}