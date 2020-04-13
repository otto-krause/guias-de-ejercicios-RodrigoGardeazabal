using System;

namespace E6
{
    public class Matematica
    {
        int i=0,a=0,b=1,fact=1,may=0,men=0;
        public void Fibonacci(int num1)
        {
            a=0;
            b=1;
            for(i=0;i<num1;i++)
            {
                Console.Write(" {0}",a);
                a=a+b;
                Console.Write(" {0}",b);
                b=a+b;
            }
            Console.Write("\n");
        }
        public int Factorial(int num1)
        {
            fact=1;
            for(i=num1;i>1;i--)
            {
                fact=fact*i;
            }
            return fact;
        }
        public int Mayor(int num1,int num2)
        {
            return (num1>num2)?num1:num2;
        }
        public int Menor(int num1,int num2)
        {
            return (num1<num2)?num1:num2;;
        }
        public int Cubo(int num1)
        {
            return num1=num1*num1*num1;
        }
    }
}