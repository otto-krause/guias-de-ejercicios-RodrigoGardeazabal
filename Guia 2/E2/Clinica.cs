using System;
using System.Collections.Generic;

namespace E2
{
    public class Clinica
    {
        public void especia(string especialid)
        {
            List<Medico> medicos =new List<Medico>();
            medicos.Add(new Medico("rodrigo", "gardeazabal", "dermatologia",50));
            medicos.Add(new Medico("Augusto", "Solari", "angiologia",30));
            medicos.Add(new Medico("Ricardo", "Alvez", "oftalmologia",123));
            medicos.Add(new Medico("Samantha", "Roberti", "traumatologia",3));
            medicos.Add(new Medico("Julio", "Dominguez", "otorrinolaringologia",40));
            medicos.Add(new Medico("Chica", "stell", "ginecologia",40));            
            for(int i=0;i<4;i++)
            {
                if(especialid==medicos[i].especialidad1())
                {
                    if(medicos[i].Estadisponible())
                    {
                        Console.WriteLine("El medico "+medicos[i].nombre1()+" "+medicos[i].apellido1()+" lo atendera");
                    }
                    else
                    {
                        Console.WriteLine("intente de nuevo mas tarde");
                    }
                }
            }
        }
    }
}