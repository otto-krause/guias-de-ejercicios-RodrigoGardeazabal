using System;

namespace E6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1=0,num2=0,opcion1=1,opcion=0;
            Matematica mate = new Matematica();
            do
            {
                Console.WriteLine("1)Fibonacci\n2)Factorial\n3)Mayor\n4)Menor\n5)Cubo");
                opcion=Int32.Parse(Console.ReadLine());
                if(opcion==1)
                {
                    Console.Write("ingresar cuantos numero de la secuencia quieres ver: ");
                    num1=Int32.Parse(Console.ReadLine());
                    mate.Fibonacci(num1);
                }
                if(opcion==2)
                {
                    Console.Write("ingresar el numero que quiere saber su factorial: ");
                    num1=Int32.Parse(Console.ReadLine());
                    Console.WriteLine("La factorial es : "+mate.Factorial(num1));
                }
                if(opcion==3)
                {

                    Console.Write("ingresa un numero: ");
                    num1=Int32.Parse(Console.ReadLine());
                    Console.Write("ingresa otro numero: ");
                    num2=Int32.Parse(Console.ReadLine());
                    Console.WriteLine("El mayor es : "+mate.Mayor(num1,num2));
                }
                if(opcion==4)
                {
                    Console.Write("ingresa un numero: ");
                    num1=Int32.Parse(Console.ReadLine());
                    Console.Write("ingresa otro numero: ");
                    num2=Int32.Parse(Console.ReadLine());
                    Console.WriteLine("El menor es : "+mate.Menor(num1,num2));
                }
                if(opcion==5)
                {
                    Console.Write("ingresa un numero: ");
                    num1=Int32.Parse(Console.ReadLine());
                    Console.WriteLine("El cubo es : "+mate.Cubo(num1));
                }
                Console.Write("¿quiere realizar otra operacion?\n1)Si\n2)No\n");
                opcion1=Int32.Parse(Console.ReadLine());    
            }while(opcion1==1);
        }
    }
}
