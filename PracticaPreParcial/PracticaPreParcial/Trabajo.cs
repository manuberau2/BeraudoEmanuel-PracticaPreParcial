using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPreParcial
{
    public class Trabajo
    {
        public int CodTrabajo { get; set; }
        public string TituloTrabajo { get; set; }
        public string DescripcionTrabajo { get; set; }
        public List<int> ListadoCodHerramientas { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaEntregaEstimada  { get; set; }
        

        
    }
}
