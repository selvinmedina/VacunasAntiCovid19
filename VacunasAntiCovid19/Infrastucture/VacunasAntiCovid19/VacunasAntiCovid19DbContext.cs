using Microsoft.EntityFrameworkCore;
using SelvinMedina.Infrastructure.Core.Extensiones;
using VacunasAntiCovid19.Infrastucture.VacunasAntiCovid19.Configs;

namespace VacunasAntiCovid19.Infrastucture.VacunasAntiCovid19
{
    public partial class VacunasAntiCovid19DbContext : DbContext
    {
        public VacunasAntiCovid19DbContext()
        {
        }

        public VacunasAntiCovid19DbContext(DbContextOptions<VacunasAntiCovid19DbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddConfiguration(new UsuarioConfig())
                .AddConfiguration(new RolConfig())
                .AddConfiguration(new VacunaConfig())
                .AddConfiguration(new DestinoVacunaConfig())
                .AddConfiguration(new CiudadanoConfig())
                .AddConfiguration(new CentroDeAsistenciaConfig())
                .AddConfiguration(new HistoricoCiudadanoConfig());
        }
    }
}
