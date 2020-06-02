using System;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animales perrito=new Perro(30);
            Animales pajarito=new Pajaro(30);
            string opcion;
            int opcion1=1;
            do
            {
                Console.WriteLine("¿Que quiere realizar?\ncomer, jugar, dormir o prefiere salir");
                opcion=Console.ReadLine();
                switch (opcion)
                {
                    case "comer":
                        Console.WriteLine("¿Con quien quiere realizar accion? ¿perro o pajaro?");
                        opcion=Console.ReadLine();
                        switch (opcion)
                        {
                            case "perro":
                                Console.WriteLine("El perro comio, ahora tiene de energia:"+perrito.comer());
                                break;
                            case "pajaro":
                                Console.WriteLine("El pajaro comio, ahora tiene de energia:"+pajarito.comer());
                                break;
                            default:
                                Console.WriteLine("ingrese una opcion real");
                                break;
                        }
                        break;
                    case "jugar":
                        Console.WriteLine("¿Con quien quiere realizar accion? ¿perro o pajaro?");
                        opcion=Console.ReadLine();
                        switch (opcion)
                        {
                            case "perro":
                                Console.WriteLine("El perro jugo, ahora tiene de energia:"+perrito.jugar());
                                break;
                            case "pajaro":
                                Console.WriteLine("El pajaro jugo, ahora tiene de energia:"+pajarito.jugar());
                                break;
                            default:
                                Console.WriteLine("ingrese una opcion real");
                                break;
                        }    
                        break;
                    case "dormir":
                        Console.WriteLine("Los animales durmieron, el perro tiene de energia "+perrito.dormir()+"y el pajaro "+pajarito.dormir());
                        break;
                    case "salir":
                        opcion1=2;
                        break;
                    default:
                        Console.WriteLine("ingrese una opcion real");
                        break;
                }
            } while(opcion1==1);
        }
    }
}
