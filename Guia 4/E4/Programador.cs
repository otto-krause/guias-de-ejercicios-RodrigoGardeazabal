using System;
namespace E4
{
    public class Programador : Empleado
    {
        public override void depositar(string tipo)
        {
            if(tipo=="junior")
            {
                cajabancaria+=10000;
            }
            else
            {
                if(tipo=="semiSenior")
                {
                    cajabancaria+=20000;
                }
                else
                {
                    if(tipo=="senior")
                    {
                        cajabancaria+=40000;
                    }
                }
            }
            cajabancaria+=20000;
        }

        public override void extraer(int extraccion)
        {
            if(cajabancaria-extraccion<0)
            {
                Console.WriteLine("no puede realizar la extraccion");
            }
            else
            {
                cajabancaria-=extraccion;
            }
        }
    }
}