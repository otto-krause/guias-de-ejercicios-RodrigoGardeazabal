using System.Collections.Generic;
namespace E5
{
    public class Carrito
    {
        List<Producto> productos=new List<Producto>();
        public Carrito()
        {
            Producto p1=new Producto("surtido bagley",50);
            Producto p2=new Producto("Leche armonia",38);
            productos.Add(p1);
            productos.Add(p2);
        }
        public int precio(string producto)
        {
            foreach (var item in productos)
            {
                if(producto==item.nombres())
                {
                    return item.precios();
                }
            }
            return 0;
        }
    }
}