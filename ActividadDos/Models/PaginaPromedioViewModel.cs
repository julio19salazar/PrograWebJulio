using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActividadDos.Models
{
  public class PaginaPromedioViewModel
    {
        public double CalificacionUno { get; set; }
        public double CalificacionDos { get; set; }
        public double CalificacionTres { get; set; }
        public double Resultado { get { return (CalificacionUno + CalificacionDos + CalificacionTres) / 3; } }
        
        public string Estado { get { return Resultado <= 100 && Resultado >= 70 ? "Aprobado" : "Reprobado"; } }
    }
}
