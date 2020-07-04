using System;
namespace E1
{
    public class Persona
    {
        int edad;
        string nombre, apellido;

        public Persona(int edad, string nombre, string apellido)
        {
            this.edad = edad;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public int Edad { get => edad; set => edad = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
    }
}