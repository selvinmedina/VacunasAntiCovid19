using System;
using System.Collections.Generic;

namespace VacunasAntiCovid19.Infrastucture.VacunasAntiCovid19.Entities
{
    public partial class CentroDeAsistencia
    {
        public int Id { get; set; }
        public string Descripcion { get; set; } = null!;
        public int Capacidad { get; set; }
        public int NumeroMedicos { get; set; }
        public int NumeroEnfermeras { get; set; }
        public int NumeroPacientesAtendidos { get; set; }
        public bool EsPublico { get; set; }
        public bool Activo { get; set; }
        public int UsuarioAgregaId { get; set; }
        public DateTime FechaAgrega { get; set; }
        public DateTime? FechaModifica { get; set; }
        public int? UsuarioModificaId { get; set; }

        public virtual Usuario UsuarioAgrega { get; set; } = null!;
        public virtual Usuario? UsuarioModifica { get; set; }
        public virtual List<HistoricoCiudadano> HistoricoCiudadanos { get; set; }
    }
}
