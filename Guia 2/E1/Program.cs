using System;
using System.Collections.Generic;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num=0,opcion=1;
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
        }
    }
}