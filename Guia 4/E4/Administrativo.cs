using System;
namespace E4
{
    public class Administrativo : Empleado
    {
        public override void depositar(string tipo)
        {
            cajabancaria+=35000;
            
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