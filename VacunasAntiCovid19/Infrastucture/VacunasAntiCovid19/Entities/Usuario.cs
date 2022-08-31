using System;
using System.Collections.Generic;

namespace VacunasAntiCovid19.Infrastucture.VacunasAntiCovid19.Entities
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public string Usuario1 { get; set; } = null!;
        public byte[] Clave { get; set; } = null!;
        public string Correo { get; set; } = null!;
        public bool Activo { get; set; }
        public int? RolId { get; set; }
        public int UsuarioAgregaId { get; set; }
        public DateTime FechaAgrega { get; set; }
        public DateTime? FechaModifica { get; set; }
        public int? UsuarioModificaId { get; set; }

        public virtual Rol? Rol { get; set; }
    }
}
