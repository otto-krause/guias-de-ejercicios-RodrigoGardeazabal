using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class AdultoComun : Adulto
    {
        List<int> listaDeIntentosDeSusto;
        public AdultoComun()
        {
            listaDeIntentosDeSusto = new List<int>{0};
        }

        public int susto(int bolsaNiño, int capacidadDeSusto){   
            
            int tolerancia = 10 * listaDeIntentosDeSusto.Where(bolsaNiñoAux => bolsaNiñoAux > 15).Count(); 
            listaDeIntentosDeSusto.Add(bolsaNiño);
            return tolerancia < capacidadDeSusto && tolerancia != 0 ? tolerancia / 2 : 0; 
        }
    }
}