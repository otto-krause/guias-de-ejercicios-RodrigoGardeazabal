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
                Console.WriteLine("¿Con quien quiere realizar la accion?\nperro, pajaro, o prefiere salir");
                opcion=Console.ReadLine();
                switch (opcion)
                {
                    case "perro":
                        Console.WriteLine("¿Que quiere realizar con el perro? ¿comer o jugar?");
                        opcion=Console.ReadLine();
                        switch (opcion)
                        {
                            case "comer":
                                Console.WriteLine("El perro comio, ahora tiene de energia:"+perrito.comer());
                                break;
                            case "jugar":
                                Console.WriteLine("El perro jugo, ahora tiene de energia:"+perrito.jugar());
                                break;
                            default:
                                Console.WriteLine("ingrese una opcion real");
                                break;
                        }
                        break;
                    case "pajaro":
                        Console.WriteLine("¿Que quiere realizar con el pajaro?¿comer o jugar?");
                        opcion=Console.ReadLine();
                        switch (opcion)
                        {
                            case "comer":
                                Console.WriteLine("El pajaro comio, ahora tiene de energia:"+pajarito.comer());
                                break;
                            case "jugar":
                                Console.WriteLine("El pajaro jugo, ahora tiene de energia:"+pajarito.jugar());
                                break;
                            default:
                                Console.WriteLine("ingrese una opcion real");
                                break;
                        }
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
