using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    //Elemento simple | Hoja
    public class Producto : Componente{

        private string nombre;
        private double precio;

        public Producto(string nombre, double precio){
            this.nombre = nombre;
            this.precio = precio;
        }

        public double ObtenerPrecio(){
            return precio;
        }

        public void MostrarInformacion(){
            Console.WriteLine($"Producto:{nombre}\nPrecio:{precio}\n\n");
        }
    }
}
