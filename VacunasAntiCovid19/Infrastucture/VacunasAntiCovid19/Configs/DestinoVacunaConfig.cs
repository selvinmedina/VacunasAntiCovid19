using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VacunasAntiCovid19.Infrastucture.VacunasAntiCovid19.Entities;

namespace VacunasAntiCovid19.Infrastucture.VacunasAntiCovid19.Configs
{
    public class DestinoVacunaConfig : IEntityTypeConfiguration<DestinoVacuna>
    {
        public void Configure(EntityTypeBuilder<DestinoVacuna> builder)
        {
            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.Descripcion).HasMaxLength(50);

            builder.Property(e => e.FechaAgrega).HasColumnType("datetime");

            builder.Property(e => e.FechaModifica).HasColumnType("datetime");
        }
    }
}
