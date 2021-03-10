using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuanLyNhanSu.Models
{
    [Table("khenthuongkyluat")]
    public class KTKL
    {
        [Key]
        public int id_nv { get; set; }
        public string khenthuong { get; set; }
        public string Lydo { get; set; }
    }
}