using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuanLyNhanSu.Models
{
    [Table("TrinhDo_ChuyenMons")]
    public class TrinhDo_ChuyenMon
    {
        [Key]
        public int MaNV { get; set; }
        public string Ma_trinhdo { get; set; }
        public string Machuyenmon { get; set; }
    }
}