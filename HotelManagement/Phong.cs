//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.Windows.Media;


namespace HotelManagement
{
    using System;
    using System.Collections.Generic;

    public partial class Phong
    {
        public Phong()
        {
            this.ChiTietPhieuThues = new HashSet<ChiTietPhieuThue>();
        }

        public virtual ICollection<ChiTietPhieuThue> ChiTietPhieuThues { get; set; }
        public virtual LoaiPhong LoaiPhong { get; set; }

        public int SoPhong { get; set; }
        public Nullable<int> ID_LoaiPhong { get; set; }
        public Nullable<bool> TinhTrang { get; set; }
        public string GhiChu { get; set; }
        public string TenLoaiPhong { get; set; }
        public Nullable<double> DonGia { get; set; }
        public Nullable<int> SLKhachToiDa { get; set; }
        public Nullable<bool> Active { get; set; }

        //For Binding
        public string ID_For_Binding { get; set; }
        public int STT_For_Binding { get; set; }
        public string Density_For_Binding { get; set; }
        public string Percent_For_Binding { get; set; }
        public string DonGia_For_Binding { get; set; }
        public string DonGiaPerDay_For_Binding { get; set; }
        public ImageSource Badage_Status_For_Binding { get; set; }
        public string SLKhachToiDa_For_Binding { get; set; }
    }
}