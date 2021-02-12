using System;
using System.Collections.Generic;
using System.Linq;
namespace E11
{
    public class Aplicación
    {
        string nombre;
        double tiempoDeUso;
        double cantidadDeToquesEnLaPantalla;
        List<string> permisos;
        double tiempoDeUsoDelTeclado;
        public Aplicación(string nombre, double tiempoDeUso, double cantidadDeToquesEnLaPantalla, List<string> permisos, double tiempoDeUsoDelTeclado)
        {
            this.nombre = nombre;
            this.tiempoDeUso = tiempoDeUso;
            this.cantidadDeToquesEnLaPantalla = cantidadDeToquesEnLaPantalla;
            this.permisos = permisos;
            this.tiempoDeUsoDelTeclado = tiempoDeUsoDelTeclado;
        }
        public string Nombre { get => nombre;}
        public double TiempoDeUso { get => tiempoDeUso;}
        public double CantidadDeToquesEnLaPantalla { get => cantidadDeToquesEnLaPantalla;}
        public List<string> Permisos { get => permisos; }
        public double TiempoDeUsoDelTeclado { get => tiempoDeUsoDelTeclado;  }
        public double interaccion()
        {
            return cantidadDeToquesEnLaPantalla/tiempoDeUso;
        }
        public double interaccionConElTeclado(){
            return (tiempoDeUsoDelTeclado/TiempoDeUso)*100;
        }
    }
}