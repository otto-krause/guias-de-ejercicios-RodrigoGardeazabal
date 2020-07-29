using System;
using System.Collections.Generic;
using System.Linq;
namespace E3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Caballeros> caballero=new List<Caballeros>();
            Armadura armaduramu=new Armadura("Armadura Aries","Oro");
            caballero.Add(new Caballeros("Mu","Hades",armaduramu,"Aries"));
            Armadura armadurashaka =new Armadura("Armadura Virgo","Oro");
            caballero.Add(new Caballeros("Shaka","Atenea",armadurashaka,"Virgo"));
            Armadura armaduraaioros=new Armadura("Armadura Sagitario","Oro");
            caballero.Add(new Caballeros("Aioros","Atenea",armaduraaioros,"Sagitario"));
            Armadura armaduraleo=new Armadura("Armadura Leo","Oro");
            caballero.Add(new Caballeros("Aioria","Poseidon",armaduraleo,"Cancer"));
            Console.WriteLine("Las armaduras que apoyan a Atena son:");
            caballero.Where(caballero => caballero.Dios=="Atenea").ToList().ForEach(caballero => Console.WriteLine(caballero.Armaduraatena()));
            List<string> Dioses =new List<string>();
            caballero.ForEach(i=>Dioses.Add(i.Dios));
            var dios=Dioses.Distinct();
            foreach (var item in dios)
            {
                Console.WriteLine(item);
            }
            int i=0;
            Console.WriteLine("Los signos que empiezan con C:");
            foreach (var item in caballero)
            {
                if(caballero[i].Signo.StartsWith("C"))
                {
                    Console.WriteLine(caballero[i].Signo);
                }
                i++;
            }
        }
    }
}
