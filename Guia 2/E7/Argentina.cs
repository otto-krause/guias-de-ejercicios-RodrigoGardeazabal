using System.Collections.Generic;
using System;
namespace E7
{
    public class Argentina
    {
        public void petroleo()
        {
            int i=0;
            foreach (var item in Program.elalfajor)
            {
                Console.WriteLine("ahora el alfajor "+Program.elalfajor[i].nombr()+" sale "+Program.elalfajor[i].preci());
                i++;
            }
        }
        public void millai()
        {
            int i=0;
            foreach (var item in Program.elalfajor)
            {
                Console.WriteLine("ahora el alfajor "+Program.elalfajor[i].nombr()+" sale "+Program.elalfajor[i].preci2());
                i++;
            }
        }
        public void coronavairas()
        {
            int i=0;
            foreach (var item in Program.elalfajor)
            {   
                if(Program.elalfajor[i].nombr()!="wuaymayen")
                {
                    Console.WriteLine("ahora el alfajor "+Program.elalfajor[i].nombr()+" sale "+Program.elalfajor[i].preci3());
                }
                i++;
            }
        }
    }
}