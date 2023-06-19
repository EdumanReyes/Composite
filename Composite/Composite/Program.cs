using Composite;

class Program
{
     static void Main(string[] args)
     { 
        
        //Productos
        var producto1 = new Producto("audifonos", 50.50);
        var producto2 = new Producto("gorra", 100.0);
        var producto3 = new Producto("camisa",200);

        //Cajas
        var caja1 = new Caja("Regalo");
        var caja2 = new Caja("Carton");

        //Empacar los productos en caja de regalo
        caja1.AgregarComponente(producto1);
        caja1.AgregarComponente(producto2);

        //Empacar caja de regalo en caja de carton 
        caja2.AgregarComponente(caja1);
        caja2.AgregarComponente(producto3); //agregar algo para mi

        caja2.MostrarInformacion();

        // Calcular el precio total del pedido
        double precioTotal = caja2.ObtenerPrecio();
        Console.WriteLine($"Precio total: {precioTotal}");

    }
}
