//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinalProject2022
{
    using System;
    using System.Collections.Generic;
    
    public partial class PHIEUNHAP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUNHAP()
        {
            this.PHIEUHANGHOAs = new HashSet<PHIEUHANGHOA>();
        }
    
        public string MAPHIEUNHAP { get; set; }
        public string TENNHACUNGCAP { get; set; }
        public Nullable<System.DateTime> NGAYNHAP { get; set; }
        public string TENKHONHAP { get; set; }
        public string DONVIVANCHUYEN { get; set; }
        public string HOTENNGUOIGIAOHANG { get; set; }
        public string DIACHIKHO { get; set; }
        public Nullable<float> THANHTIEN { get; set; }
        public string MANHANVIEN { get; set; }
    
        public virtual NHANVIEN NHANVIEN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUHANGHOA> PHIEUHANGHOAs { get; set; }
    }
}