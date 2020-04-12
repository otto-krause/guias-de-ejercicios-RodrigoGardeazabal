using System;

namespace spisoo
{
    public class tp
    {
        static void Main(string[] args)
        {
            int[] vector = new int[10];
            int i,opcion=0,resultado=0,menor=1000000,temp,j;
            Console.WriteLine("Ingrese 10 numeros");
            for(i=0;i<=9;i++)
            {
                vector[i]=Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("ingrese la opcion");
            opcion=Int32.Parse(Console.ReadLine());
            if(opcion==1)
            {
                for(i=0;i<=9;i++)
                {
                    resultado+=vector[i];
                }
                Console.WriteLine(resultado);
            }
            if(opcion==2)
            {
                for(i=0;i<=9;i++)
                {
                    resultado+=vector[i];
                }
                resultado/=10;
                Console.WriteLine(resultado);
            }
            if(opcion==3)
            {
                for(i=0;i<=9;i++)
                {
                    if(vector[i]<menor)
                    {
                        menor=vector[i];
                    }
                }
                Console.WriteLine("el menor numero ingresado es {0}",menor);
            }
            if(opcion==4)
            {
                for(i=0;i<(10-1);i++) 
                { 
                    for(j=i+1;j<10;j++) 
                    { 
                        if (vector[j]<vector[i]) 
                        { 
                            temp=vector[j]; 
                            vector[j]=vector[i]; 
                            vector[i]=temp; 
                        } 
                    } 
                }
                Console.WriteLine("el orden es:");
                for(i=0;i<=9;i++)
                {
                    Console.WriteLine(vector[i]);
                }
            }
        }
    }
}