//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DMCWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblHoSoBienDong
    {
        public long MaDangKyBienDong { get; set; }
        public Nullable<long> MaHoSo { get; set; }
        public Nullable<System.DateTime> NgayXongDangKyBienDong { get; set; }
        public Nullable<bool> DaXongBienDong { get; set; }
        public string LoaiBienDong { get; set; }
        public string LoaiDoiTuongApDung { get; set; }
    }
}