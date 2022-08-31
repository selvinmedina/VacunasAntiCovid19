using System;
using System.Collections.Generic;

namespace VacunasAntiCovid19.Infrastucture.VacunasAntiCovid19.Entities
{
    public partial class Rol
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = null!;
        public bool Activo { get; set; }
        public int UsuarioAgregaId { get; set; }
        public DateTime FechaAgrega { get; set; }
        public DateTime? FechaModifica { get; set; }
        public int? UsuarioModificaId { get; set; }

        public virtual Usuario UsuarioAgrega { get; set; } = null!;
        public virtual Usuario? UsuarioModifica { get; set; }
        public virtual List<Usuario>? Usuarios { get; set; }
    }
}
