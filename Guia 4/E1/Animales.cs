namespace E1
{
    public abstract class Animales
    {
        protected int energia;
        public Animales(int energia)
        {
            this.energia=energia;
        }
        public abstract int comer();
        public abstract int jugar();
        public abstract int dormir();
    }
}