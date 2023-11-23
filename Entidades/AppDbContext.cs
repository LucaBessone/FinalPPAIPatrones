using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAI_DSI_EntregaFinalPatrones;
using PPAI_CU44_G1_3K6.Entidades;

namespace PPAI_DSI_EntregaFinalPatrones.Entidades
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public AppDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=ELAP0041\\SQLEXPRESS; Database=PPAIDSICF; User=sa; Password=Luca1234; TrustServerCertificate=True");
            }
        }
        // DbSet para cada entidad en tu modelo
        public DbSet<CambioDeEstado> CambioDeEstado { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Encuesta> Encuesta { get; set; }
        public DbSet<Estado> Estado { get; set; }
        public DbSet<Llamada> Llamada { get; set; }
        public DbSet<Pregunta> Pregunta { get; set; }
        public DbSet<RespuestaDeCliente> RespuestaDeCliente { get; set; }
        public DbSet<RespuestaPosible> RespuestaPosible { get; set; }

    }
}
