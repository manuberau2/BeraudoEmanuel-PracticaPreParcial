using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPreParcial
{
    public class Gestion
    {
        public List<Herramienta> ListadoHerramientas { get; set; }
        public List<Trabajo> ListadoTrabajos { get; set; }
        public Gestion() 
        {
            ListadoHerramientas = new List<Herramienta>();
            ListadoTrabajos = new List<Trabajo>();
        }

        public bool AgregarProducto(Herramienta herramienta)
        {
            if (herramienta.Descripcion != null && herramienta.Nombre != null && herramienta.Precio != 0)
            {
                switch (herramienta)
                {
                    case HerramientaManual herramientaManual:
                        if (herramientaManual.FechaAdquirida != default)
                        {
                            HerramientaManual herramientaManual1 = new HerramientaManual()
                            {
                                CodHerramienta = ListadoHerramientas.Count + 1,
                                Descripcion = herramientaManual.Descripcion,
                                FechaAdquirida = herramientaManual.FechaAdquirida,
                                Nombre = herramientaManual.Nombre,
                                Precio = herramientaManual.Precio
                            };
                        }
                        else return false;
                        break;
                    case HerramientaElectrica herramientaElectrica:
                        if (herramientaElectrica.Potencia != 0 && herramientaElectrica.TipoHerramienta != 0 && herramientaElectrica.FechaFinalizacionGarantia != default)
                        {
                            HerramientaElectrica herramientaElectrica1 = new HerramientaElectrica()
                            {
                                CodHerramienta = ListadoHerramientas.Count + 1,
                                Descripcion = herramientaElectrica.Descripcion,
                                FechaFinalizacionGarantia = herramientaElectrica.FechaFinalizacionGarantia,
                                Nombre = herramientaElectrica.Nombre,
                                Potencia = herramientaElectrica.Potencia,
                                Precio = herramientaElectrica.Precio,
                                TipoHerramienta = herramientaElectrica.TipoHerramienta
                            };
                        }
                        else return false;
                        break;
                    default:
                        break;
                }
                ListadoHerramientas.Add(herramienta);
                return true;
            }
            return false;
        }

        public string DevolverDescripcionHerramienta(int codHerramienta)
        {
            Herramienta herramienta = ListadoHerramientas.Where(n=> n.CodHerramienta == codHerramienta).FirstOrDefault();
            if (herramienta == null)
            {
                return "¡ERROR! La herramienta no existe";
            }
            return herramienta.DevolverDescripcion();
        }


        public Resultado AgregarTrabajo(string tituloTrabajo, string descripcionTrabajo, DateTime fechaInicio, List<int> listadoHerramientas)
        {
            Resultado resultado = new Resultado();
            int contElectricas = 0;
            int contManuales = 0;
            if (tituloTrabajo !=  null && descripcionTrabajo != null && fechaInicio != default)
            {
                Trabajo trabajo = new Trabajo()
                {
                    CodTrabajo = ListadoTrabajos.Count + 1,
                    DescripcionTrabajo = descripcionTrabajo,
                    TituloTrabajo = tituloTrabajo,
                    ListadoCodHerramientas = listadoHerramientas,
                    FechaInicio = fechaInicio
                };
                foreach (int i in listadoHerramientas)
                {
                    var herramienta = ListadoHerramientas.FirstOrDefault(x => x.CodHerramienta == i);
                    if (herramienta is HerramientaElectrica) 
                    {
                        contElectricas++;
                    } else 
                    {
                        contManuales++; 
                    }
                }
                if (contElectricas > 3) 
                {
                    fechaInicio.AddDays(5);
                } else
                {
                    fechaInicio.AddDays(3);
                }
                if (contManuales > 5)
                {
                    fechaInicio.AddDays(10);
                } else
                {
                    fechaInicio.AddDays(2);
                }
                trabajo.FechaEntregaEstimada = fechaInicio;
                ListadoTrabajos.Add(trabajo);
                resultado.Mensaje = "Se agregó exitosamete el trabajo";
                resultado.Exito = true;
            } else
            {
                resultado.Mensaje = "No se agregó el trabajo debido a que se paso incorrectamente algún dato";
            }
            return resultado;
        }
    }
}
