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
    
    public partial class ApaCalda
    {
        public int Index { get; set; }
        public int IdApartament { get; set; }
        public decimal Index_Vechi { get; set; }
        public decimal Index_Nou { get; set; }
        public decimal Consum { get; set; }
        public decimal Pret_m_cub { get; set; }
        public decimal Suma_de_Plata { get; set; }
        public System.DateTime Data_emitere { get; set; }
    
        public virtual Apartamente Apartamente { get; set; }
    }
}
