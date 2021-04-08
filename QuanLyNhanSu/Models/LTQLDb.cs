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
        public virtual DbSet<ChucVu > ChucVus { get; set; }
        public virtual DbSet<PhongBan> PhongBans { get; set; }
        public virtual DbSet<KTKL> khenthuongkyluat { get; set; }
        public virtual DbSet<TrinhDo>TrinhDos { get; set; }
        public virtual DbSet<ThanNhan>ThanNhans { get; set; }
        public virtual DbSet<ChiTietNghiViec> ChiTietNghiViecs { get; set; }
        public virtual DbSet<CongTac> CongTacs { get; set; }
        public virtual DbSet<ChuyenMon> ChuyenMons { get; set; }
        public virtual DbSet<TrinhDo_ChuyenMon> TrinhDo_ChuyenMons { get; set; }
        public virtual DbSet<ChuyenPhong> ChuyenPhongs { get; set; }
        public virtual DbSet<DuAn> DuAns { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaNV);
            modelBuilder.Entity<ChucVu>()
                .Property(e => e.Machucvu);
        }
    }
}
