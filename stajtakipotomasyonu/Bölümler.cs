//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StajTakipOtomasyonu
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bölümler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bölümler()
        {
            this.Programlar = new HashSet<Programlar>();
        }
    
        public int ID { get; set; }
        public string BolumAdi { get; set; }
        public string KisaAdi { get; set; }
        public int Baskan { get; set; }
    
        public virtual Akademisyen Akademisyen { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Programlar> Programlar { get; set; }
    }
}
