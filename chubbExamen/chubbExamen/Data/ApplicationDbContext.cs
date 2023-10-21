using Azure;
using chubbExamen.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace chubbExamen.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.Entity<tbl_Persona>()
            //    .HasOne(p => p.Direccion)
            //    .WithMany(d => d.Personas).HasForeignKey(f => f.IdDireccion);

            //builder.Entity<tbl_Direccion>()
            //       .HasOne(d => d.Colonia)
            //       .WithMany(c => c.Direcciones).HasForeignKey(f => f.IdColonia);

            //builder.Entity<tbl_Colonia>()
            //      .HasOne(c => c.Municipio)
            //      .WithMany(m => m.Colonias).HasForeignKey(f => f.IdMunicipio);

            //builder.Entity<tbl_Municipio>()
            //    .HasOne(m => m.Estado)
            //    .WithMany(e => e.Municipios).HasForeignKey(f => f.IdEstado);

            //var EDOMEX = new tbl_Estado() { IdEstado=1,Nombre="Estado de México",status=true};

            //builder.Entity<tbl_Estado>().HasData(EDOMEX);

            //var Huehuetoca = new tbl_Municipio() {IdMunicipio = 1, Nombre = "Huehuetoca", IdEstado = 1, status = true };
            //var Coyotepec = new tbl_Municipio() { IdMunicipio = 2, Nombre = "Coyotepec", IdEstado = 1, status = true };

            //builder.Entity<tbl_Municipio>().HasData(new tbl_Municipio[] {Huehuetoca,Coyotepec});

            //var centro = new tbl_Colonia() {IdColonia = 1, Nombre = "Centro", CP = "54680", IdMunicipio = 1, status = true };
            //var SantaTeresa = new tbl_Colonia() { IdColonia = 2, Nombre = "Santa Teresa", CP = "54694", IdMunicipio = 1, status = true };

            //builder.Entity<tbl_Colonia>().HasData(new tbl_Colonia[] { centro,SantaTeresa });




            base.OnModelCreating(builder);
        }
        public DbSet<tbl_Persona> tbl_Persona { get; set; }
        public DbSet<tbl_Direccion> tbl_Direccion { get; set; }
        public DbSet<tbl_Colonia> tbl_Colonia { get; set;}
        public DbSet<tbl_Municipio> tbl_Municipio { get; set; }
        public DbSet<tbl_Estado> tbl_Estado { get; set;}
    }
}
