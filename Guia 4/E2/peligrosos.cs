using System;
using System.Collections.Generic;
namespace E2
{
    public class peligrosos : Monsterinc
    {
        public static int m=0;
        public override void NochedeRisas(string nombremonstruo)
        {
            int puntos=0,i=0,igual=0,j=0;
            if(m==0)
            {
                puntos-=2;
                monstruos.Add(new Monstruos(nombremonstruo,puntos));
                m++;
            }
            else
            {
                foreach (var item in monstruos)
                {
                    if(nombremonstruo==monstruos[i].nombre())
                    {
                        j=i;
                        igual++;
                    }
                    i++;
                }
                if(igual==0)
                {
                    puntos-=2;
                    monstruos.Add(new Monstruos(nombremonstruo,puntos));
                }
                else
                {
                    monstruos[j].Puntos-=2;
                }
            }
        }

        public override void NochedeSustos(string nombremonstruo)
        {
            int puntos=0,i=0,igual=0,j=0;
            if(m==0)
            {
                puntos+=5;
                monstruos.Add(new Monstruos(nombremonstruo,puntos));
                m++;
            }
            else
            {
                foreach (var item in monstruos)
                {
                    if(nombremonstruo==monstruos[i].nombre())
                    {
                        j=i;
                        igual++;
                    }
                    i++;
                }
                if(igual==0)
                {
                    puntos+=5;
                    monstruos.Add(new Monstruos(nombremonstruo,puntos));
                }
                else
                {
                    monstruos[j].Puntos+=5;
                }
            }
        }
        public override void respetables()
        {
            foreach (var item in monstruos)
            {
                if(item.Puntos>70)
                {
                    Console.WriteLine(item.nombre());
                }
            }
        }
        public override int energia()
        {
            int energia=0;
            foreach (var item in monstruos)
            {
                energia+=item.Puntos;
            }
            return energia;
        }
    }
}