using System;
using System.Linq;
using System.Collections.Generic;
namespace E7
{
    public class RedSocial
    {
        DateTime fechaActual = DateTime.Today;
        Cuenta maria;
        Cuenta viviana;
        Cuenta pedro;
        Foto foto1;
        Foto foto2;
        Foto foto3;
        Foto foto4;
        List<string> amigos; 
        List<string> publicaciones;
        List<string> publicacionesTotales;
        List<Foto> albumDeFotos;
        List<Foto> fotosTotal;
        List<Cuenta> personasTotal;
        public RedSocial(){
            foto1 = new Foto("C:/storage/DCIM","21-07-2012",new List<string>{"David Azara","Bastian Soloro","Sebastian Soto"});
            foto2 = new Foto("C:/storage/DCIM","30-05-2018",new List<string>{"Adrian Rodriguez","Bastian Soloro"});
            foto3 = new Foto("C:/storage/DCIM","01-01-2020",new List<string>{"Cristian Correa","Thiago Correa"});
            foto4 = new Foto("C:/storage/DCIM","03-03-2014",new List<string>{"Andrea Cohen","Florencia Estrella"});
            fotosTotal = new List<Foto>{foto1,foto2,foto3,foto4};
            publicaciones = new List<string>{"Meh",":v"};
            albumDeFotos = new List<Foto>{foto1,foto3,foto4};
            amigos = new List<string>{"Adrian Rodriguez","David Azara"};
            maria = new Cuenta("Cristian Correa",amigos,publicaciones,albumDeFotos);

            publicaciones = new List<string>{"...","Feo"};
            albumDeFotos = new List<Foto>{foto1,foto2,foto3};
            amigos = new List<string>{"Adrian Rodriguez","David Azara"};
            viviana = new Cuenta("Andrea Cohen",amigos,publicaciones,albumDeFotos);

            publicaciones = new List<string>{"bue cansas","sale suicidarse"};
            albumDeFotos = new List<Foto>{foto1,foto2,foto4};
            amigos = new List<string>{"Andrea Cohen","Adrian Rodriguez"};
            pedro = new Cuenta("David Azara",amigos,publicaciones,albumDeFotos);
            
            personasTotal = new List<Cuenta>{maria,viviana,pedro};
            publicacionesTotales = new List<string>{"te odio","Ya no se que poner","que tarea chota ahre","Comentario idiota","F","me aburri"};
        }
        public List<Foto> fotosUltimoAño(string persona){
            List<Foto> fotoAux = new List<Foto>();
            fotoAux = fotosTotal.Where(foto => foto.PersonasEtiquetadas.Contains(persona) 
            && foto.FechaDeCreacion.Contains("2020"))
            .ToList();
            return fotoAux = fotoAux.Count()>0 ? fotoAux : null;  
        }
        public List<Foto> fotosEtiquetadas(string persona1, string persona2){
            List<Foto> fotoAux1 = new List<Foto>();
            fotoAux1 = fotosTotal.Where(foto => foto.
            PersonasEtiquetadas.Contains(persona1) && foto.PersonasEtiquetadas.Contains(persona2)).ToList();
            return fotoAux1 = fotoAux1.Count()>0 ? fotoAux1 : null;
        }
        public List<string> publicacionesDeMas300Caracteres(){
            List<string> publicacionesAux = new List<string>();
            publicacionesAux = publicacionesTotales.Where(publicacion => publicacion.Count() > 300).ToList();
            return publicacionesAux = publicacionesAux.Count() > 0 ? publicacionesAux : null;
        }
    }
}