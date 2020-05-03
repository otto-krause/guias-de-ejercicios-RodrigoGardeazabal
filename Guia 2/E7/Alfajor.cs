using System.Collections.Generic;
using System;
namespace E7
{
    public class Alfajor
    {
        string nombre,empresa;
        int precio;
        public Alfajor(string nombre, string empresa,int precio)
        {
            this.nombre=nombre;
            this.empresa=empresa;
            this.precio=precio;
        }
        public string nombr()
        {
            return nombre;
        }
        public int estado()
        {
            return precio;
        }
        public int preci()
        {
            return precio=precio+80;
        }
        public int preci2()
        {
            return precio=precio*2;
        }
        public int preci3()
        {
            return precio=precio+1000;
        }
    }
}