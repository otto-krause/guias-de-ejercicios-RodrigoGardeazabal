using System.Collections.Generic;
namespace E5
{
    public class Supermercado
    {
        List<Carrito> carritos=new List<Carrito>();
        string producto;
        int cantidad;
        public Supermercado(string producto, int cantidad)
        {
            this.producto=producto;
            this.cantidad=cantidad;
            Carrito carrito1=new Carrito();
            carritos.Add(carrito1);
        }
        public int ganancias()
        {
            int precio=0;
            foreach (var item in carritos)
            {
                precio=item.precio(producto);
            }
            return precio*cantidad;
        }
    }
}