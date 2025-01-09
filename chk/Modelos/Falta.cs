using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chk.Modelos
{
    public class Falta
    {

        public Falta() { }
        //Atributos de la clase falta
        public int IDFalta { get; set; }
        public string Matricula { get; set; } = string.Empty;
        public string Departamento { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string Cargo { get; set; } = string.Empty;
        public string MotivoFalta { get; set; } = string.Empty;
        public DateTime?FechaInicioFalta { get; set; }
        public DateTime? FechaFinFalta { get; set; }

    }
}
