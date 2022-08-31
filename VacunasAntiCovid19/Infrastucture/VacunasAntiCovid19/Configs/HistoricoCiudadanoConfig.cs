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
    internal class HistoricoCiudadanoConfig : IEntityTypeConfiguration<HistoricoCiudadano>
    {
        public void Configure(EntityTypeBuilder<HistoricoCiudadano> builder)
        {
            builder.Property(e => e.Id).ValueGeneratedNever();

            builder.Property(e => e.FechaAgrega).HasColumnType("datetime");

            builder.Property(e => e.FechaAplicacion).HasColumnType("datetime");

            builder.Property(e => e.FechaModifica).HasColumnType("datetime");

            builder.HasOne(d => d.CentroDeAsistencia)
                .WithMany(p => p.HistoricoCiudadanos)
                .HasForeignKey(d => d.CentroDeAsistenciaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HistoricoCiudadano_CentroDeAsistencia");

            builder.HasOne(d => d.Ciudadano)
                .WithMany(p => p.HistoricoCiudadanos)
                .HasForeignKey(d => d.CiudadanoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HistoricoCiudadano_Ciudadano");

            builder.HasOne(d => d.Vacuna)
                .WithMany(p => p.HistoricoCiudadano)
                .HasForeignKey(d => d.VacunaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HistoricoCiudadano_Vacuna");
        }
    }
}
