namespace E4
{
    public class Gatito
    {
        string nombre;
        bool vacunas;
        int energia;
        public Gatito(string nombre, bool vacunas, int energia)
        {
            this.nombre=nombre;
            this.vacunas=vacunas;
            this.energia=energia;
        }
        public bool estasaludable()
        {
            return vacunas && energia >30;
        }
        public string nombregat()
        {
            return nombre;
        }
        public bool estavacunado()
        {
            return vacunas;
        }
        public int juego(int minutos)
        {
            return energia=energia-minutos*2;
        }
        public int comio()
        {
            return energia+=50;
        }
    }
}