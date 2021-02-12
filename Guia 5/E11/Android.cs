using System;
using System.Collections.Generic;
using System.Linq;
namespace E11
{
    public class Android
    {
        List<Aplicación> todasLasAplicaciones=new List<Aplicación>();
        public Android()
        {
            todasLasAplicaciones.Add(new Aplicación("Pokemon Go",2,50,new List<string>{"fotos"},0));
            todasLasAplicaciones.Add(new Aplicación("Facebook Lite",5,30,new List<string>{"videos","fotos","archivos","contactos"},3));
            todasLasAplicaciones.Add(new Aplicación("Telefono",1,20,new List<string>{"contactos"},1));
        }
        public List<Aplicación> juegos()
        {
            return todasLasAplicaciones.Where(app => app.interaccion() >= 24 && app.interaccion() <= 26).ToList();
        }
        public List<Aplicación> redes()
        {
            return todasLasAplicaciones.Where(app => app.Permisos.Contains("videos") && app.Permisos.Contains("fotos") && app.interaccionConElTeclado() > 20).ToList();
        } 
        public List<Aplicación> otros()
        {
            return todasLasAplicaciones.Where(app => !(app.Permisos.Any(i => i == "videos") && app.Permisos.Any(i => i == "fotos") && (app.interaccionConElTeclado()>20)) && !(app.interaccion() >= 24 && app.interaccion() <= 26)).ToList();
        }
    }
}