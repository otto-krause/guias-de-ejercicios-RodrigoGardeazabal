using System;
using System.Collections.Generic;

namespace E3
{
    public class Mundial
    {
        string nombre,pais,posicion;
        int figurita;
        public Mundial(string nombre, string posicion, string pais, int figurita)
        {
            this.nombre=nombre;
            this.posicion=posicion;
            this.pais=pais;
            this.figurita=figurita;
        }
        public int figur()
        {
            return figurita;
        }
        public string posici()
        {
            return posicion;
        }
        public string paises()
        {
            return pais;
        }
        public bool posic()
        {
            return "mediocampista"==posicion;
        }
    }
}