using System;

namespace E4
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion1,empleado,tipo="";
            int extraccion,opcion=1;
            Empleado administrativo=new Administrativo();
            Empleado rrhh=new RRHH();
            Empleado programador=new Programador();
            do
            {
                Console.WriteLine("¿Quiere depositar, extraer, salir?");
                opcion1=Console.ReadLine();
                switch (opcion1)
                {
                    case "depositar":
                        Console.WriteLine("A quien le quiere depositar:");
                        empleado=Console.ReadLine();
                        switch (empleado)
                        {
                            case "administrativo":
                                administrativo.depositar(tipo);
                                break;
                            case "rrhh":
                                Console.WriteLine("¿es referida?si o no");
                                tipo=Console.ReadLine();
                                rrhh.depositar(tipo);
                                break;
                            case "programador":
                                Console.WriteLine("¿sos junior, semiSenior o senior");
                                tipo=Console.ReadLine();
                                programador.depositar(tipo);
                                break;
                            default:
                                Console.WriteLine("ingrese una opcion real");
                                break;
                        }
                        break;
                    case "extraer":
                        Console.WriteLine("A quien le quiere extraer:");
                        empleado=Console.ReadLine();
                        switch (empleado)
                        {
                            case "administrativo":
                                Console.WriteLine("cuanto quiere extraer?");
                                extraccion=Int32.Parse(Console.ReadLine());
                                administrativo.extraer(extraccion);
                                break;
                            case "rrhh":
                                Console.WriteLine("cuanto quiere extraer?");
                                extraccion=Int32.Parse(Console.ReadLine());
                                rrhh.extraer(extraccion);
                                break;
                            case "programador":
                            Console.WriteLine("cuanto quiere extraer?");
                                extraccion=Int32.Parse(Console.ReadLine());
                                programador.extraer(extraccion);
                                break;
                            default:
                                Console.WriteLine("ingrese una opcion real");
                                break;
                        }
                        break;
                    case "salir":
                        opcion=2;
                        break;
                    default:
                        Console.WriteLine("ingrese una opcion real");
                        break;
                }
            } while(opcion==1);
        }
    }
}
