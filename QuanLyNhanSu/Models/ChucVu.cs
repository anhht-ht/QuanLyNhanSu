using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuanLyNhanSu.Models
{
    [Table("ChucVus")]
    public class ChucVu
    {
        [Key]
        public string Machucvu { get; set; }
        public string Tenchucvu { get; set; }
    }
}