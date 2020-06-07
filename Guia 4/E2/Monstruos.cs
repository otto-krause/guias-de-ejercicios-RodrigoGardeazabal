namespace E2
{
    public class Monstruos
    {
        string Nombre;
        int puntos;
        public Monstruos(string Nombre,int puntos)
        {
            this.Nombre=Nombre;
            this.puntos=puntos;
        }

        public int Puntos { get => puntos; set => puntos = value; }

        public string nombre()
        {
            return Nombre;
        }
    }
}