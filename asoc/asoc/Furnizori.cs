//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace asoc
{
    using System;
    using System.Collections.Generic;
    
    public partial class Furnizori
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Furnizori()
        {
            this.Facturi_Furnizori = new HashSet<Facturi_Furnizori>();
        }
    
        public decimal CUI { get; set; }
        public string Nume { get; set; }
        public string Email { get; set; }
        public string Serviciu { get; set; }
        public System.DateTime Data_semnare_contract { get; set; }
        public System.DateTime Data_expirare_contract { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Facturi_Furnizori> Facturi_Furnizori { get; set; }
    }
}