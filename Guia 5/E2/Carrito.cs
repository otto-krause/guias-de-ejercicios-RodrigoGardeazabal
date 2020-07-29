using System.Collections.Generic;
using System.Linq;

namespace E2
{
    public class Carrito
    {
        List<Producto> productos = new List<Producto>();
        public Carrito()
        {
            Producto produ1 = new Producto ("Flan", 50);
            Producto produ2 = new Producto ("Leche", 40);
            productos.Add(produ1);
            productos.Add(produ2);
        }
        public int Precio(string producto)
        {
            foreach (var k in productos)
            {
                if(producto == k.Nombre)
                    return k.Precio;
            }
            return 0;
        }        
    }
}