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
    
    public partial class PHIEUHANGHOA
    {
        public string MAPHIEUNHAP { get; set; }
        public string MASANPHAM { get; set; }
        public Nullable<int> SOLUONG { get; set; }
        public Nullable<int> DONGIA { get; set; }
    
        public virtual HANGHOA HANGHOA { get; set; }
        public virtual PHIEUNHAP PHIEUNHAP { get; set; }
    }
}
