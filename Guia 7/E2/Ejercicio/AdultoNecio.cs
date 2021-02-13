using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class AdultoNecio : Adulto
    {
        List<int> listaDeIntentosDeSusto; 
        public AdultoNecio()
        {
            listaDeIntentosDeSusto = new List<int>{0};
        }

        public int susto(int bolsaNiño, int capacidadDeSusto){
            listaDeIntentosDeSusto.Add(bolsaNiño);
            return 0; 
        }
    }
}