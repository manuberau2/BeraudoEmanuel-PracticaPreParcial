using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPreParcial
{
    public class HerramientaElectrica : Herramienta
    {
        public int Potencia { get; set; }
        public TiposHerramientas TipoHerramienta { get; set; }
        public DateTime FechaFinalizacionGarantia { get; set; }

        public override string DevolverDescripcion()
        {
            return $"Esta es una herramienta eléctrica que tiene una potencia de {Potencia} watts y que tiene garantía hasta el {FechaFinalizacionGarantia}";
        }
    }
}
