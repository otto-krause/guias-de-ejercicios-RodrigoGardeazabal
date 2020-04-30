namespace E5
{
    public class Producto
    {
        string nombre;
        int precio;
        public Producto(string nombre, int precio)
        {
            this.nombre=nombre;
            this.precio=precio;
        }
        public string nombres()
        {
            return nombre;
        }
        public int precios()
        {
            return precio;
        }
    }
}