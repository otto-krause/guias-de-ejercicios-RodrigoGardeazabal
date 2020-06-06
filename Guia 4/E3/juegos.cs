namespace E3
{
    public class juegos
    {
        string nombre,consola;
        int año;

        public juegos(string nombre, string consola,int año)
        {
            this.nombre = nombre;
            this.año = año;
            this.consola = consola;
        }
        public string nomb()
        {
            return nombre;
        }
        public int años()
        {
            return año;
        }
    }
}