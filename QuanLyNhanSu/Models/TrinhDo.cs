using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuanLyNhanSu.Models
{
    [Table("TrinhDos")]
    public class TrinhDo
    {
        [Key]
        public string Ma_trinhdo { get; set; }
        public string Ten_trinhdo { get; set; }
    }
}