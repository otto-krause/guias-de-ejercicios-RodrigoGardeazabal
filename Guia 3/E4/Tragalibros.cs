using System;
using System.Collections.Generic;
namespace E4
{
    public class Tragalibros
    {
        int cantidad=0;
        public List<Libro> libros =new List<Libro>();
        
        public int leer()
        {
            int j=0,i=0;
            string titulo,autor;
            Console.Write("ingrese el titulo del libro:");
            titulo=Console.ReadLine();
            Console.Write("ingrese el autor:");
            autor=Console.ReadLine();
            if(cantidad==0)
            {
                libros.Add(new Libro(titulo,autor));
                cantidad=1;
                return 1;
            }
            else
            {
                foreach (var item in libros)
                {
                    if(titulo!=item.titulos())
                    {
                        i++;
                    }
                    j++;
                }
                if(j==i)
                {
                    libros.Add(new Libro(titulo,autor));
                    return 1;
                }
                else
                {
                    Console.WriteLine("el libro esta repetido");
                }
                return 0;
            }
        }
        public int Calcular(int canti)
        {
            return canti*5;
        }
    }
}