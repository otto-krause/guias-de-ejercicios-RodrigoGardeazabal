using System;

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            Monsterinc peligroso=new peligrosos();
            Monsterinc amigable=new amigables();
            string opcion,monstruo,nombremonstruo;
            int opcion1=1;
            int noche=1,energia=0;
            do
            {
                noche=1;
                Console.WriteLine("si quiere una noche de sustos ingrese sustos\nsi quiere una noche de risas ingrese risas\nsi quiere ver a los respetable ingrese respetables\nsi quiere ver la energia actual de la empresa ingrese energia\nsi prefiere salir ingrese salir.");
                opcion=Console.ReadLine();
                switch (opcion)
                {
                    case "sustos":
                        while(noche==1)
                        {
                            Console.WriteLine("¿que tipo de monstruo hara asustar?,peligroso o amigable");
                            monstruo=Console.ReadLine();
                            if(monstruo=="peligroso")
                            {
                                Console.WriteLine("ingrese el nombre del monstruo");
                                nombremonstruo=Console.ReadLine();
                                peligroso.NochedeSustos(nombremonstruo);
                            }
                            else
                            {
                                if(monstruo=="amigable")
                                {
                                    Console.WriteLine("ingrese el nombre del monstruo");
                                    nombremonstruo=Console.ReadLine();
                                    amigable.NochedeSustos(nombremonstruo);
                                }
                                else
                                {
                                    Console.WriteLine("Tipo de monstruo incorrecto");
                                }
                            }
                            Console.WriteLine("¿quiere ingresar otro monstruo?");
                            noche=Int32.Parse(Console.ReadLine());
                        }
                        break;
                    case "risas":
                        while(noche==1)
                        {
                            Console.WriteLine("¿que tipo de monstruo hara asustar?,peligroso o amigable");
                            monstruo=Console.ReadLine();
                            if(monstruo=="peligroso")
                            {
                                Console.WriteLine("ingrese el nombre del monstruo");
                                nombremonstruo=Console.ReadLine();
                                peligroso.NochedeSustos(nombremonstruo);
                            }
                            else
                            {
                                if(monstruo=="amigable")
                                {
                                    Console.WriteLine("ingrese el nombre del monstruo");
                                    nombremonstruo=Console.ReadLine();
                                    amigable.NochedeSustos(nombremonstruo);
                                }
                                else
                                {
                                    Console.WriteLine("Tipo de monstruo incorrecto");
                                }
                            }
                            Console.WriteLine("¿quiere ingresar otro monstruo?\n1)si\n2)no");
                            noche=Int32.Parse(Console.ReadLine());
                        }
                        break;
                    case "respetables":
                        Console.WriteLine("Los monstruos peligrosos respetables son:");
                        peligroso.respetables();
                        Console.WriteLine("Los monstruos amigables respetables son:");
                        amigable.respetables();
                        break;
                    case "energia":
                        energia=peligroso.energia()+amigable.energia();
                        Console.WriteLine("La energia de la empresa es de: "+energia);
                        energia=0;
                        break;
                    case "salir":
                        opcion1=2;
                        break;
                    default:
                        break;
                }
            }while(opcion1==1);
        }
    }
}
