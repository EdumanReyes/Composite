using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Caja: Componente {
        private string nombre;
        private List<Componente> componentes; //Los componentes de una caja pueden ser otras cajas o un producto

        public Caja(string nombre){
            this.nombre = nombre;
            componentes = new List<Componente>();
        }
        public void AgregarComponente(Componente componente){
            componentes.Add(componente);
        }
        public double ObtenerPrecio(){
            double precioTotal = 0.0;
            foreach (var componente in componentes){
                precioTotal += componente.ObtenerPrecio();
            }
            return precioTotal;
        }
        public void MostrarInformacion(){
            Console.WriteLine($"Caja: {nombre}");
            foreach (var componente in componentes){
                componente.MostrarInformacion();
            }
        }
    }
}
