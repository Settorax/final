﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Asociatie_ProprietariEntities : DbContext
    {
        public Asociatie_ProprietariEntities()
            : base("name=Asociatie_ProprietariEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Agent_Termic> Agent_Termic { get; set; }
        public virtual DbSet<Angajati> Angajati { get; set; }
        public virtual DbSet<ApaCalda> ApaCalda { get; set; }
        public virtual DbSet<ApaRece> ApaRece { get; set; }
        public virtual DbSet<Apartamente> Apartamente { get; set; }
        public virtual DbSet<Canalizare> Canalizare { get; set; }
        public virtual DbSet<Carduri> Carduri { get; set; }
        public virtual DbSet<Coduri> Coduri { get; set; }
        public virtual DbSet<Contracte_Individuale> Contracte_Individuale { get; set; }
        public virtual DbSet<Conturi_de_Utilizator> Conturi_de_Utilizator { get; set; }
        public virtual DbSet<Cota_Parte> Cota_Parte { get; set; }
        public virtual DbSet<Curatenie> Curatenie { get; set; }
        public virtual DbSet<Date_Angajati> Date_Angajati { get; set; }
        public virtual DbSet<EnergieElecrica_pe_scara> EnergieElecrica_pe_scara { get; set; }
        public virtual DbSet<EnergieElectrica> EnergieElectrica { get; set; }
        public virtual DbSet<Facturi_Clienti> Facturi_Clienti { get; set; }
        public virtual DbSet<Facturi_Furnizori> Facturi_Furnizori { get; set; }
        public virtual DbSet<Fond_Reparatii> Fond_Reparatii { get; set; }
        public virtual DbSet<Fond_Rulment> Fond_Rulment { get; set; }
        public virtual DbSet<Furnizori> Furnizori { get; set; }
        public virtual DbSet<Gaz> Gaz { get; set; }
        public virtual DbSet<Lift> Lift { get; set; }
        public virtual DbSet<Locatari> Locatari { get; set; }
        public virtual DbSet<Membri_Asociatie> Membri_Asociatie { get; set; }
        public virtual DbSet<Restante> Restante { get; set; }
        public virtual DbSet<Salarii_Angajati> Salarii_Angajati { get; set; }
        public virtual DbSet<Salubritate> Salubritate { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Venituri> Venituri { get; set; }
    
        public virtual ObjectResult<detaliiFactuaCotaParte_Result> detaliiFactuaCotaParte(string luna_facturare, Nullable<int> id_apartament, string an_facturare)
        {
            var luna_facturareParameter = luna_facturare != null ?
                new ObjectParameter("luna_facturare", luna_facturare) :
                new ObjectParameter("luna_facturare", typeof(string));
    
            var id_apartamentParameter = id_apartament.HasValue ?
                new ObjectParameter("id_apartament", id_apartament) :
                new ObjectParameter("id_apartament", typeof(int));
    
            var an_facturareParameter = an_facturare != null ?
                new ObjectParameter("an_facturare", an_facturare) :
                new ObjectParameter("an_facturare", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<detaliiFactuaCotaParte_Result>("detaliiFactuaCotaParte", luna_facturareParameter, id_apartamentParameter, an_facturareParameter);
        }
    
        public virtual ObjectResult<detaliiFactura_Result> detaliiFactura(string perioada_facturare, Nullable<int> id_apartament)
        {
            var perioada_facturareParameter = perioada_facturare != null ?
                new ObjectParameter("perioada_facturare", perioada_facturare) :
                new ObjectParameter("perioada_facturare", typeof(string));
    
            var id_apartamentParameter = id_apartament.HasValue ?
                new ObjectParameter("id_apartament", id_apartament) :
                new ObjectParameter("id_apartament", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<detaliiFactura_Result>("detaliiFactura", perioada_facturareParameter, id_apartamentParameter);
        }
    
        public virtual ObjectResult<detaliiFacturaCurenta_Result> detaliiFacturaCurenta(string luna_facturare, Nullable<int> id_apartament, string an_facturare)
        {
            var luna_facturareParameter = luna_facturare != null ?
                new ObjectParameter("luna_facturare", luna_facturare) :
                new ObjectParameter("luna_facturare", typeof(string));
    
            var id_apartamentParameter = id_apartament.HasValue ?
                new ObjectParameter("id_apartament", id_apartament) :
                new ObjectParameter("id_apartament", typeof(int));
    
            var an_facturareParameter = an_facturare != null ?
                new ObjectParameter("an_facturare", an_facturare) :
                new ObjectParameter("an_facturare", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<detaliiFacturaCurenta_Result>("detaliiFacturaCurenta", luna_facturareParameter, id_apartamentParameter, an_facturareParameter);
        }
    
        public virtual ObjectResult<detaliiRestanta_Result> detaliiRestanta(Nullable<int> numar_apartament)
        {
            var numar_apartamentParameter = numar_apartament.HasValue ?
                new ObjectParameter("numar_apartament", numar_apartament) :
                new ObjectParameter("numar_apartament", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<detaliiRestanta_Result>("detaliiRestanta", numar_apartamentParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<detaliiFactura1_Result> detaliiFactura1(string luna_facturare, Nullable<int> id_apartament, string an_facturare)
        {
            var luna_facturareParameter = luna_facturare != null ?
                new ObjectParameter("luna_facturare", luna_facturare) :
                new ObjectParameter("luna_facturare", typeof(string));
    
            var id_apartamentParameter = id_apartament.HasValue ?
                new ObjectParameter("id_apartament", id_apartament) :
                new ObjectParameter("id_apartament", typeof(int));
    
            var an_facturareParameter = an_facturare != null ?
                new ObjectParameter("an_facturare", an_facturare) :
                new ObjectParameter("an_facturare", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<detaliiFactura1_Result>("detaliiFactura1", luna_facturareParameter, id_apartamentParameter, an_facturareParameter);
        }
    
        public virtual ObjectResult<detaliiFacturiCotaParte_Result> detaliiFacturiCotaParte(string luna_facturare, Nullable<int> id_apartament, string an_facturare)
        {
            var luna_facturareParameter = luna_facturare != null ?
                new ObjectParameter("luna_facturare", luna_facturare) :
                new ObjectParameter("luna_facturare", typeof(string));
    
            var id_apartamentParameter = id_apartament.HasValue ?
                new ObjectParameter("id_apartament", id_apartament) :
                new ObjectParameter("id_apartament", typeof(int));
    
            var an_facturareParameter = an_facturare != null ?
                new ObjectParameter("an_facturare", an_facturare) :
                new ObjectParameter("an_facturare", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<detaliiFacturiCotaParte_Result>("detaliiFacturiCotaParte", luna_facturareParameter, id_apartamentParameter, an_facturareParameter);
        }
    
        public virtual ObjectResult<detaliiFactuaCotaParte1_Result> detaliiFactuaCotaParte1(string luna_facturare, Nullable<int> id_apartament, string an_facturare)
        {
            var luna_facturareParameter = luna_facturare != null ?
                new ObjectParameter("luna_facturare", luna_facturare) :
                new ObjectParameter("luna_facturare", typeof(string));
    
            var id_apartamentParameter = id_apartament.HasValue ?
                new ObjectParameter("id_apartament", id_apartament) :
                new ObjectParameter("id_apartament", typeof(int));
    
            var an_facturareParameter = an_facturare != null ?
                new ObjectParameter("an_facturare", an_facturare) :
                new ObjectParameter("an_facturare", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<detaliiFactuaCotaParte1_Result>("detaliiFactuaCotaParte1", luna_facturareParameter, id_apartamentParameter, an_facturareParameter);
        }
    
        public virtual ObjectResult<detaliiRestante1_Result> detaliiRestante1(Nullable<int> numar_apartament)
        {
            var numar_apartamentParameter = numar_apartament.HasValue ?
                new ObjectParameter("numar_apartament", numar_apartament) :
                new ObjectParameter("numar_apartament", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<detaliiRestante1_Result>("detaliiRestante1", numar_apartamentParameter);
        }
    }
}
