using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPreParcial
{
    public class HerramientaManual : Herramienta
    {
        public DateTime FechaAdquirida { get; set; }

        public override string DevolverDescripcion()
        {
            return $"Esta es una herramienta manual que se adquirió en 19/08/2020";
        }
    }
}
