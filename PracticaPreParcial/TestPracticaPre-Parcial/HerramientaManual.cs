using PracticaPreParcial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPracticaPre_Parcial
{
    public class HerramientaManualTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DescripcionHerramientaManual()
        {
            Gestion gestion = new Gestion();
            bool resultado = gestion.AgregarProducto(new HerramientaManual { Descripcion = "Es util", Nombre = "Pala", FechaAdquirida = DateTime.Parse("19/08/2020"), Precio = 8000 });
            string descripcion = gestion.ListadoHerramientas[0].DevolverDescripcion();
            Assert.That(descripcion == $"Esta es una herramienta manual que se adquirió en 19/08/2020");
        }
    }
    
}
