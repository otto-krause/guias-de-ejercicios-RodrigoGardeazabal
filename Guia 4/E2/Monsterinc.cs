using System.Collections.Generic;
namespace E2
{
    public abstract class Monsterinc
    {
        protected List<Monstruos> monstruos;

        public Monsterinc()
        {
            this.monstruos=new List<Monstruos>();
        }
        public abstract void NochedeSustos(string nombremonstruo);
        public abstract void NochedeRisas(string nombremonstruo);
        public abstract void respetables();
        public abstract int energia();
    }
}