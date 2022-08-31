﻿using System;
using System.Collections.Generic;

namespace VacunasAntiCovid19.Infrastucture.VacunasAntiCovid19.Entities
{
    public partial class Vacuna
    {
        public Vacuna()
        {
            HistoricoCiudadano = new HashSet<HistoricoCiudadano>();
        }

        public int Id { get; set; }
        public string Identidad { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public DateTime FechaNacimiento { get; set; }
        public bool Activo { get; set; }
        public int UsuarioAgregaId { get; set; }
        public DateTime FechaAgrega { get; set; }
        public DateTime? FechaModifica { get; set; }
        public int? UsuarioModificaId { get; set; }

        public virtual Usuario UsuarioAgrega { get; set; } = null!;
        public virtual Usuario? UsuarioModifica { get; set; }
        public virtual ICollection<HistoricoCiudadano> HistoricoCiudadano { get; set; }
    }
}
