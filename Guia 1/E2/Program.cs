using System;

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1,num2,opcion=0,i=0,result=0,resto=0;
            Console.WriteLine("ingrese los numeros:");
            num1=Int32.Parse(Console.ReadLine());
            num2=Int32.Parse(Console.ReadLine()); 
            Console.WriteLine("1)multiplicacion\n2)division");
            opcion=Int32.Parse(Console.ReadLine());
            if(opcion==1)
            {
                for(i=0;i<num2;i++)
                {
                    result+=num1;
                }
                Console.WriteLine("la multiplicacion es {0}",result);
            }
            if(opcion==2)
            {
                while(num1>=num2)
                {
                    num1-=num2;
                    result+=1;
                    resto=num1;
                }
            }
            Console.WriteLine("la division es {0} y el resto es {1}",result,resto);
        }
    }
}