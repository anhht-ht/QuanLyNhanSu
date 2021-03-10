using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLyNhanSu.Models
{
    public partial class LTQLDb : DbContext
    {
        public LTQLDb()
            : base("name=LTQLDb")
        {
        }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<ChucVu > ChucVus { get; set; }
        public virtual DbSet<PhongBan> PhongBans { get; set; }
        public virtual DbSet<KTKL> khenthuongkyluat { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NhanVien>()
                .Property(e => e.id);
            modelBuilder.Entity<ChucVu>()
                .Property(e => e.Machucvu);
        }
    }
}
