using PracticaPreParcial;

namespace TestPracticaPre_Parcial
{
    public class GestionTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AgregarProducto_SeAgregaManualCorrectamenteDeberiaDarTrue()
        {
            Gestion gestion = new Gestion();
            bool resultado = gestion.AgregarProducto(new HerramientaManual { Descripcion = "Es util", Nombre = "Pala", FechaAdquirida = DateTime.Parse("19/08/2020"), Precio = 8000 });
            Assert.That(resultado, Is.True);
        }
        [Test]
        public void AgregarProducto_SeAgregaManualIncorrectamenteDeberiaDarFalse()
        {
            Gestion gestion = new Gestion();
            bool resultado = gestion.AgregarProducto(new HerramientaManual { Nombre = "Pala", FechaAdquirida = DateTime.Parse("19/08/2020"), Precio = 0 });
            Assert.That(resultado, Is.False);
        }
        [Test]
        public void AgregarProducto_SeAgregaElectricaCorrectamenteDeberiaDarTrue()
        {
            Gestion gestion = new Gestion();
            bool resultado = gestion.AgregarProducto(new HerramientaElectrica { Descripcion = "Es util", Nombre = "Pala", Precio = 8000, Potencia = 2, TipoHerramienta = TiposHerramientas.Lijadora, FechaFinalizacionGarantia = DateTime.Parse("18/08/2021") });
            Assert.That(resultado, Is.True);
        }

        [Test]
        public void AgregarProducto_SeAgregaElectricaCorrectamenteDeberiaDarFalse()
        {
            Gestion gestion = new Gestion();
            bool resultado = gestion.AgregarProducto(new HerramientaElectrica { Descripcion = "Es util", Nombre = "Pala", Precio = 8000, Potencia = 2, FechaFinalizacionGarantia = DateTime.Parse("18/08/2021") });
            Assert.That(resultado, Is.False);
        }
    }
}