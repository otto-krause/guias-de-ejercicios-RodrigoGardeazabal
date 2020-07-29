using System.Collections.Generic;
namespace E3
{
    public class Caballeros
    {
        private string nombre;
        private string dios;
        private Armadura armadura;
        private string signo;

        public Caballeros(string nombre, string dios, Armadura armadura, string signo)
        {
            this.nombre = nombre;
            this.dios = dios;
            this.armadura = armadura;
            this.signo = signo;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Dios { get => dios; set => dios = value; }
        public Armadura Armadura { get => armadura; set => armadura = value; }
        public string Signo { get => signo; set => signo = value; }

        public string Armaduraatena()
        {
            return "Nombre de la armadura: "+armadura.Nombre+"\nMaterial de la armadura: "+armadura.Material;
        }
    }
}