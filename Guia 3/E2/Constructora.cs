using System;
using System.Collections.Generic;
namespace E2
{
    public class Constructora
    {
        int presupuesto;
        int cantidadDeHorasDeTrabajo;
        List<contratistas> contratistas = new List<contratistas>();
        public Constructora(int presupuesto, int cantidadDeHorasDeTrabajo, List<contratistas> contratistas)
        {
            this.presupuesto = presupuesto;
            this.cantidadDeHorasDeTrabajo = cantidadDeHorasDeTrabajo;
            this.contratistas = contratistas;
        }
        public bool sePuede()
        {
            int acu = 0;
            foreach (var i in contratistas)
            {
                i.trabajar(cantidadDeHorasDeTrabajo);
                acu += i.cobrar();
            }
            Console.WriteLine(acu);
            return presupuesto > acu;
        }
    }
}