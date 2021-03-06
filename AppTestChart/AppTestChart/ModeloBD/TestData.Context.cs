﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppTestChart.ModeloBD
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class TestDataEntities : DbContext
    {
        public TestDataEntities()
            : base("name=TestDataEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Configuracion> Configuracion { get; set; }
        public virtual DbSet<Mascotas> Mascotas { get; set; }
        public virtual DbSet<Pdfs> Pdfs { get; set; }
    
        public virtual ObjectResult<pb_getMascotas_Result> pb_getMascotas()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<pb_getMascotas_Result>("pb_getMascotas");
        }
    
        public virtual ObjectResult<sp_getMascotas_Result> sp_getMascotas()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_getMascotas_Result>("sp_getMascotas");
        }
    
        public virtual ObjectResult<Nullable<int>> sp_GetConfig()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_GetConfig");
        }
    
        public virtual ObjectResult<Nullable<int>> sp_setTime(Nullable<int> tiempoEspera)
        {
            var tiempoEsperaParameter = tiempoEspera.HasValue ?
                new ObjectParameter("tiempoEspera", tiempoEspera) :
                new ObjectParameter("tiempoEspera", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_setTime", tiempoEsperaParameter);
        }
    
        public virtual int sp_setPdf(string namePdf, string srcP)
        {
            var namePdfParameter = namePdf != null ?
                new ObjectParameter("namePdf", namePdf) :
                new ObjectParameter("namePdf", typeof(string));
    
            var srcPParameter = srcP != null ?
                new ObjectParameter("srcP", srcP) :
                new ObjectParameter("srcP", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_setPdf", namePdfParameter, srcPParameter);
        }
    
        public virtual ObjectResult<string> sp_getPdf(string namePdf)
        {
            var namePdfParameter = namePdf != null ?
                new ObjectParameter("namePdf", namePdf) :
                new ObjectParameter("namePdf", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("sp_getPdf", namePdfParameter);
        }
    }
}
