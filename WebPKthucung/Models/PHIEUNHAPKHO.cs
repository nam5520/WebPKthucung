//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebPKthucung.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class PHIEUNHAPKHO
    {
        public string MAPHIEUNK { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public System.DateTime NGAYNK { get; set; }
        public string MASP { get; set; }
        public int SOLUONG { get; set; }
    
        public virtual SANPHAM SANPHAM { get; set; }
    }
}