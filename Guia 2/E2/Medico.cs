using System;
using System.Collections.Generic;

namespace E2
{
    public class Medico
    {
        string nombre,apellido,especialidad;
        int cantiturn=0;

        public int Cantiturn { get => cantiturn; set => cantiturn = value; }

        public Medico(string nombre, string apellido, string especialidad, int cantiturn)
        {
            this.nombre=nombre;
            this.apellido=apellido;
            this.especialidad=especialidad;
            this.cantiturn=cantiturn;
        }
        public string nombre1()
        {
            return nombre;
        }
        public string apellido1()
        {
            return apellido;
        }
        public String especialidad1()
        {
            return especialidad;
        }
        public bool Estadisponible()
        {
            return cantiturn<50;
        }
        public int nuevoturn()
        {
            return cantiturn++;
        }
    }
}