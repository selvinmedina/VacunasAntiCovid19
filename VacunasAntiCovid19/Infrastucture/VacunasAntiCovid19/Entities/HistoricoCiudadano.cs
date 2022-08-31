using System;
using System.Collections.Generic;

namespace VacunasAntiCovid19.Infrastucture.VacunasAntiCovid19.Entities
{
    public partial class HistoricoCiudadano
    {
        public int Id { get; set; }
        public int VacunaId { get; set; }
        public int CiudadanoId { get; set; }
        public int CentroDeAsistenciaId { get; set; }
        public DateTime FechaAplicacion { get; set; }
        public bool Activo { get; set; }
        public int UsuarioAgregaId { get; set; }
        public DateTime FechaAgrega { get; set; }
        public DateTime? FechaModifica { get; set; }
        public int? UsuarioModificaId { get; set; }

        public virtual CentroDeAsistencia CentroDeAsistencia { get; set; } = null!;
        public virtual Ciudadano Ciudadano { get; set; } = null!;
        public virtual Usuario UsuarioAgrega { get; set; } = null!;
        public virtual Usuario? UsuarioModifica { get; set; }
        public virtual Vacuna Vacuna { get; set; } = null!;
    }
}
