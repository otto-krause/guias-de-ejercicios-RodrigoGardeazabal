using System;
using System.Linq;
using System.Collections.Generic;
namespace E10
{
    class Program
    {
        static void Main(string[] args)
        {
            int mas=0,idiomas=0,plata=0,visitados=0;
            bool fueExitoso = false;
            List<excompañeros> excompañeros = new List<excompañeros>();
            do
            {
                Console.WriteLine("Ingrese la cantidad de idiomas que conoce:");
                idiomas=Int32.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad de plata que gana en un mes:");
                plata=Int32.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad de paises que visito:");
                visitados=Int32.Parse(Console.ReadLine());
                excompañeros.Add(new excompañeros(idiomas, plata, visitados));
                Console.WriteLine("¿Quiere ingresar otro alumno?si o no");
                string opcion=Console.ReadLine();
                if(opcion=="no")
                {
                    mas=1;
                }
                
            } while (mas==0);
            switch(excompañeros.Count(x => x.Idiomas > 5))
            {
                case 0:
                    fueExitoso = false;
                    break;
                default:        
                    if(excompañeros.Count(x => x.Idiomas >= 2) == excompañeros.Count())
                    {
                        switch(excompañeros.Count(x => x.Paises > 3))
                        {
                                case 3:
                                    fueExitoso = false;
                                    break;
                                default:
                                    switch(excompañeros.Count(x => x.Ganancias > 200000))
                                    {
                                        case 5:
                                            fueExitoso = false;
                                            break;
                                        default:
                                            fueExitoso = true;
                                            break;
                                    }
                                    break;
                            }
                            break;
                    }
                    break;
            }
            Console.WriteLine("El curso fue exitoso? " + fueExitoso);
        }
    }
}