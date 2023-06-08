using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPreParcial
{
    public abstract class Herramienta
    {
        public int CodHerramienta { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Precio { get; set; }

        public abstract string DevolverDescripcion();
    }
}
