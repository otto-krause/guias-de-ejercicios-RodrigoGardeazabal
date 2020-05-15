using System;
using System.Collections.Generic;
namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            int total=0,j=0,presupuesto=10000,horas=3;
            List<Contratista> contratis=new List<Contratista>();
            var Plomeros1=new Contratista(horas,0);
            var Plomeros2=new Contratista(horas,0);
            var Plomeros3=new Contratista(horas,0);
            var Plomeros4=new Contratista(horas,0);
            var Plomeros5=new Contratista(horas,0);
            var Pintores1=new Contratista(horas,0);
            var Pintores2=new Contratista(horas,0);
            var Pintores3=new Contratista(horas,0);
            var Pintores4=new Contratista(horas,0);
            var Pintores5=new Contratista(horas,0);
            var Albañiles1=new Contratista(horas,0);
            var Albañiles2=new Contratista(horas,0);
            var Albañiles3=new Contratista(horas,0);
            var Albañiles4=new Contratista(horas,0);
            var Albañiles5=new Contratista(horas,0);
            contratis.Add(Plomeros1);
            contratis.Add(Plomeros2);
            contratis.Add(Plomeros3);
            contratis.Add(Plomeros4);
            contratis.Add(Plomeros5);
            contratis.Add(Pintores1);
            contratis.Add(Pintores2);
            contratis.Add(Pintores3);
            contratis.Add(Pintores4);
            contratis.Add(Pintores5);
            contratis.Add(Albañiles1);
            contratis.Add(Albañiles2);
            contratis.Add(Albañiles3);
            contratis.Add(Albañiles4);
            contratis.Add(Albañiles5);
            foreach (var i in contratis)
            {
                if(j<5)
                {
                    contratis[j].Cobrar1=contratis[j].horasa()*3*50;                    
                    total+=contratis[j].Cobrar1;
                }
                else
                {
                    if(j<10)
                    {
                        contratis[j].Cobrar1=contratis[j].horasa()*80;                        
                        total+=contratis[j].Cobrar1;
                    }
                    else
                    {
                        if(j<15)
                        {
                            contratis[j].Cobrar1=contratis[j].horasa()*50;                            
                            total+=contratis[j].Cobrar1;
                        }
                    }
                }
                Console.WriteLine(contratis[j].cobro());
                j++;
            }
            if(total<=presupuesto)
            {
                Console.WriteLine("el presupuesto ingresado alcanza para llevar acabo el proyecto");
            }
            else
            {
                Console.WriteLine("el presupuesto ingresado no les alcanza para llevar acabo el proyecto");
            }
        }
    }
}
