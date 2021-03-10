using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuanLyNhanSu.Models
{
    [Table("PhongBans")]
    public class PhongBan
    {
        [Key]
        public String Ma_phongban  { get; set; }
        public String Ten_phongban { get; set; }
    }
}