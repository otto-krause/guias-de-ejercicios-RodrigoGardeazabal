using System;

namespace E5
{
    class Program
    {
        static void Main(string[] args)
        {
            int teorema1=0,teorema2=0,teorema3=0,opcion=0,lado1=0,lado2=0,lado3=0,hayobjeto=0,lados=0,opc=0,esequi=0,opcion1=0;
            Triangulo tri=new Triangulo();
            do
            {
                Console.WriteLine("1)Ingresa los lados\n2)crear objeto\n3)ver mensajes");
                opcion=Int32.Parse(Console.ReadLine());
                if(opcion==1)
                {
                    Console.WriteLine("ingresar el lado 1 del triangulo");
                    lado1=Int32.Parse(Console.ReadLine());
                    Console.WriteLine("ingresar el lado 2 del triangulo");
                    lado2=Int32.Parse(Console.ReadLine());
                    Console.WriteLine("ingresar el lado 3 del triangulo");
                    lado3=Int32.Parse(Console.ReadLine());
                    lados=1;
                }
                if(opcion==2)
                {
                    if(lados==1)
                    {
                        if(lado1==lado2&&lado2==lado3)
                        {
                            opc=1;
                        }
                        if(lado1==lado2&&lado2!=lado3)
                        {
                            opc=2;
                        }
                        if(lado1!=lado2&&lado2!=lado3)
                        {
                            opc=3;
                        }
                        teorema1=lado1*lado1;
                        teorema2=lado2*lado2;
                        teorema3=lado3*lado3;
                        if(teorema1+teorema2==teorema3)
                        {
                            esequi=1;
                        }
                        hayobjeto=1;
                    }
                    else
                    {
                        Console.WriteLine("ingrese los lados");
                    }
                }
                if(opcion==3)
                {
                    if(hayobjeto==1)
                    {
                        Console.WriteLine("¿El triangulo es escaleno?:"+tri.EsEscaleno(opc));
                        Console.WriteLine("¿El triangulo es isosceles?:"+tri.EsIsosceles(opc));
                        Console.WriteLine("¿El triangulo es equilatero?:"+tri.EsEquilatero(opc));
                        Console.WriteLine("¿El triangulo es un Triangulo Rectangulo?:"+tri.EsTrianguloRectangulo(esequi));
                    }
                    else
                    {
                        Console.WriteLine("cree el objeto");
                    }
                }
                Console.WriteLine("¿Quiere realizar otra operacion?\n1)Si\n2)No");
                opcion1=Int32.Parse(Console.ReadLine());
            }while(opcion1==1);
        }
    }
}