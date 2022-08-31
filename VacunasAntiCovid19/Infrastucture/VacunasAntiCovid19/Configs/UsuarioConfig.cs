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
    public class UsuarioConfig : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.Property(e => e.Clave)
                    .HasMaxLength(64)
                    .IsFixedLength();

            builder.Property(e => e.Correo).HasMaxLength(50);

            builder.Property(e => e.FechaAgrega).HasColumnType("datetime");

            builder.Property(e => e.FechaModifica).HasColumnType("datetime");

            builder.Property(e => e.Usuario1)
                .HasMaxLength(50)
                .HasColumnName("Usuario");

            builder.HasOne(d => d.Rol)
                .WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.RolId)
                .HasConstraintName("FK_Usuario_Rol");
        }
    }
}
