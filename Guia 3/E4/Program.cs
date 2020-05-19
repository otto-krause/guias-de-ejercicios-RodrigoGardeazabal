using System;
using System.Collections.Generic;
namespace E4
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion=1,opcion1,canti=0;
            Tragalibros tragalibros=new Tragalibros();
            do
            {
                
                Console.WriteLine("1)Leer\n2)CalcularCI\n3)Salir");
                opcion1=Int32.Parse(Console.ReadLine());
                if(opcion1==1)
                {
                    canti+=tragalibros.leer();
                }
                else
                {
                    if(opcion1==2)
                    {
                        Console.WriteLine("Tu CI es de:"+tragalibros.Calcular(canti));
                    }
                    else
                    {
                        if(opcion1==3)
                        {
                            opcion=2;
                        }
                        else
                        {
                            Console.WriteLine("ingrese una opcion real");
                        }
                    }
                }
            }
            while(opcion==1);
        }
    }
}