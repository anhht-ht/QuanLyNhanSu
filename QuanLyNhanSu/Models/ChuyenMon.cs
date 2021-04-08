using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuanLyNhanSu.Models
{
    [Table("ChuyenMons")]
    public class ChuyenMon
    {
        [Key]
        public int Machuyenmon { get; set; }
        public string Tenchuyenmon { get; set; }
    }
}