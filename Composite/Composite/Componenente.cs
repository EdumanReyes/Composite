using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{   /* Aqui se define las operaciones comunes para los elementos simples y complejos*/
    public interface Componente { 
        double ObtenerPrecio();
        void MostrarInformacion();
    }
}
