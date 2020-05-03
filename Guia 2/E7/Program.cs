using System;
using System.Collections.Generic;
namespace E7
{
    class Program
    {
        public static List<Alfajor> elalfajor=new List<Alfajor>();
        static void Main(string[] args)
        {
            string evento;
            int estado=0;
            int opcion1=2;
            Argentina argen=new Argentina();
            elalfajor.Add(new Alfajor("mani","fulbito",14));
            elalfajor.Add(new Alfajor("dulce de leche","wuaymayen",18));
            elalfajor.Add(new Alfajor("dulce de leche","capitan del espacio",32));
            elalfajor.Add(new Alfajor("chocolate","capitan del espacio",22));
            do
            {
                Console.WriteLine("¿que evento ocurrio?\nbajar el precio del petroleo\nmillai habla por tv\ncoronavairas");
                evento=Console.ReadLine();
                if("bajar el precio del petroleo"==evento)
                {
                    argen.petroleo();
                }
                else
                {
                    if("millai habla por tv"==evento)
                    {
                        argen.millai();
                    }
                    else
                    {
                        if("coronavairas"==evento)
                        {
                            argen.coronavairas();
                        }
                    }
                }
                Console.Write("el estado de la inflacion es :");
                int i=0;
                foreach (var item in elalfajor)
                {
                    estado+=elalfajor[i].estado();
                    i++;
                }
                if(estado<500)
                {
                    Console.WriteLine("normal");
                }
                else
                {
                    if(estado>500&&estado<1000)
                    {
                        Console.WriteLine("super");
                    }
                    else
                    {
                        if(estado>1000)
                        {
                            Console.WriteLine("hyper");
                            Console.WriteLine("la argentina esta en default");
                        }
                    }
                }
                Console.WriteLine("a ocurrido otro evento?\n1)si\n2)no");
                estado=0;
                opcion1=Int32.Parse(Console.ReadLine());
            }
            while(opcion1==1);
        }
    }
}