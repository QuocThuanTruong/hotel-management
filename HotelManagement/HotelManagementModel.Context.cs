﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelManagement
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class HotelManagementEntities : DbContext
    {
        public HotelManagementEntities()
            : base("name=HotelManagementEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CauHinh> CauHinhs { get; set; }
        public virtual DbSet<ChiTietPhieuThue> ChiTietPhieuThues { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiKhach> LoaiKhaches { get; set; }
        public virtual DbSet<LoaiPhong> LoaiPhongs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PhieuThue> PhieuThues { get; set; }
        public virtual DbSet<Phong> Phongs { get; set; }
    
        [DbFunction("HotelManagementEntities", "func_getAllRoom")]
        public virtual IQueryable<func_getAllRoom_Result> func_getAllRoom()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<func_getAllRoom_Result>("[HotelManagementEntities].[func_getAllRoom]()");
        }
    
        [DbFunction("HotelManagementEntities", "func_GetCustomerInRoom")]
        public virtual IQueryable<func_GetCustomerInRoom_Result> func_GetCustomerInRoom(Nullable<int> iD_PhieuThue)
        {
            var iD_PhieuThueParameter = iD_PhieuThue.HasValue ?
                new ObjectParameter("ID_PhieuThue", iD_PhieuThue) :
                new ObjectParameter("ID_PhieuThue", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<func_GetCustomerInRoom_Result>("[HotelManagementEntities].[func_GetCustomerInRoom](@ID_PhieuThue)", iD_PhieuThueParameter);
        }
    }
}