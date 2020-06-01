namespace E1
{
    public class Pajaro: Animales
    {
        public Pajaro(int energia):base(energia)
        {
        }
        public override int comer()
        {
            return energia+=10;
        }
        public override int jugar()
        {
            return energia-=5;
        }
    }
}