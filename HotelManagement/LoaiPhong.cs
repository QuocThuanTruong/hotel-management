//------------------------------------------------------------------------------
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
    using System.Collections.Generic;

    public partial class LoaiPhong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiPhong()
        {
            this.Phongs = new HashSet<Phong>();
        }

        public LoaiPhong(int ID, string TenLoaiPhong)
        {
            this.ID_LoaiPhong = ID;
            this.TenLoaiPhong = TenLoaiPhong;

            this.Phongs = new HashSet<Phong>();
        }

        public int ID_LoaiPhong { get; set; }
        public string TenLoaiPhong { get; set; }
        public Nullable<double> DonGia { get; set; }
        public Nullable<int> SLKhachToiDa { get; set; }
        public Nullable<bool> Active { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Phong> Phongs { get; set; }

        //FOR BINDING

        public string Revenue_For_Binding { get; set; }
        public string Percent_For_Binding { get; set; }
    }
}