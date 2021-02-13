namespace Ejercicio
{
    public class Ladron : Villano
    {
        string tipo;
        int cantidadDeMaldades;
        string estado;
        public Ladron(string tipo)
        {
            this.tipo = tipo;
            this.cantidadDeMaldades = 0;
        }
        public int fuerza()
        {
            return cantidadDeMaldades;
        }
        public void cometerCrimen(CiudadGotica ciudad)
        {
            ciudad.robos(tipo);
            cantidadDeMaldades++;
        }
        public int cuantosVillanosSon()
        {
            return 1;
        }
        public void peleaConBatman(string comoMeDejoBatman)
        {
            estado = comoMeDejoBatman;
        }
        public bool estaProfugo()
        {
            return estado == "Profugo";
        }
    }
}