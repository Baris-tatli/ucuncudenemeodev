//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OkulProje
{
    using System;
    using System.Collections.Generic;
    
    public partial class odev_ogrenci
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public odev_ogrenci()
        {
            this.odev_ogrenciders = new HashSet<odev_ogrenciders>();
        }
    
        public short ogrenci_id { get; set; }
        public string ogrenci_fullname { get; set; }
        public Nullable<System.DateTime> ogrenci_recorddate { get; set; }
        public Nullable<System.DateTime> ogrenci_birthdate { get; set; }
        public string ogrenci_bolum { get; set; }
        public string ogrenci_no { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<odev_ogrenciders> odev_ogrenciders { get; set; }
    }
}
