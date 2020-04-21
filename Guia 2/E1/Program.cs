using System;
using System.Collections.Generic;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num=0,opcion=1,cant=0,i=0,may=0;
            List<int> numeros=new List<int>();
            Console.WriteLine("ingrese numeros, si ingresa 0 ya no podra ingresar");
            while(opcion==1)
            {
                num=Int32.Parse(Console.ReadLine());
                if(num!=0)
                {
                    numeros.Add(num);
                }
                else
                {
                    opcion=2;
                }
            }
            foreach(int num1 in numeros)
            {
                if(num1>50)
                {
                    may++;
                }
                Console.WriteLine("el numero es :"+num1);
                cant++;
            }
            Console.WriteLine("la cantidad de numeros ingresados es de :"+cant);
            Console.WriteLine("el primer numero ingresado fue: "+numeros[i]+"\nel ultimo fue:"+numeros[cant-1]);
            Console.WriteLine("la cantidad de numeros que superan 50 es de :"+may);
        }
    }
}