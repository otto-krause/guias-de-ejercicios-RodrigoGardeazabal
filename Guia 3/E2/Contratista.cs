using System;
namespace E2
{
    public class Contratista
    {
        int Trabajar=0;
        int Cobrar=0;
        public Contratista(int Trabajar,int Cobrar)
        {
            this.Trabajar=Trabajar;
            this.Cobrar=Cobrar;
        }

        public int Cobrar1 { get => Cobrar; set => Cobrar = value; }
        public int cobro()
        {
            return Cobrar;
        }
        public int horasa()
        {
            return Trabajar;
        }
    }
}