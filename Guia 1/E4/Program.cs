using System;

namespace E4
{
    class Program
    {
        class gatito
        {
            static void Main(string[] args)
            {
                int opcion1=1,opcion=0,minutos=0;
                Gatito batman=new Gatito("batman",true,31);
                do
                {
                    Console.WriteLine("1)Nombre\n2)¿Esta vacunado?\n3)Jugar\n4)Comer\n5)¿Esta saludable?");
                    opcion=Int32.Parse(Console.ReadLine());
                    if(opcion==1)
                    {
                        Console.WriteLine("El nombre del gatito es: "+batman.nombregat());
                    }
                    if(opcion==2)
                    {
                        Console.WriteLine("El gatito esta vacunado: "+batman.estavacunado());
                    }
                    if(opcion==3)
                    {
                        Console.WriteLine("¿Cuantos minutos jugara el gatito?");
                        minutos=Int32.Parse(Console.ReadLine());
                        Console.WriteLine("El gatito jugo, ahora tiene de energia: "+batman.juego(minutos));
                    }
                    if(opcion==4)
                    {
                        Console.WriteLine("El gatito comio, ahora tiene de energia: "+batman.comio());
                    }
                    if(opcion==5)
                    {
                        Console.WriteLine("El gatito esta saludable: "+batman.estasaludable());
                    }
                    Console.WriteLine("¿quiere realizar o saber algo mas del gatito?\n1)si\n2)no");
                    opcion1=Int32.Parse(Console.ReadLine());
                }
                while(opcion1==1);
            }
        }
    }
}
