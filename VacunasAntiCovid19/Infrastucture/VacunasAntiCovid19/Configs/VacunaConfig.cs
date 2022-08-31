using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VacunasAntiCovid19.Infrastucture.VacunasAntiCovid19.Entities;

namespace VacunasAntiCovid19.Infrastucture.VacunasAntiCovid19.Configs
{
    public class VacunaConfig : IEntityTypeConfiguration<Vacuna>
    {
        public void Configure(EntityTypeBuilder<Vacuna> builder)
        {

            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.Apellido).HasMaxLength(50);

            builder.Property(e => e.FechaAgrega).HasColumnType("datetime");

            builder.Property(e => e.FechaModifica).HasColumnType("datetime");

            builder.Property(e => e.FechaNacimiento).HasColumnType("date");

            builder.Property(e => e.Identidad).HasMaxLength(50);

            builder.Property(e => e.Nombre).HasMaxLength(50);
        }
    }
}
