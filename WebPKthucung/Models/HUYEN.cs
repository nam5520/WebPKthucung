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
    
    public partial class HUYEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HUYEN()
        {
            this.XAs = new HashSet<XA>();
        }
    
        public string MAHUYEN { get; set; }
        public string TENTINH { get; set; }
        public string MATINH { get; set; }
    
        public virtual TINH TINH { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XA> XAs { get; set; }
    }
}
