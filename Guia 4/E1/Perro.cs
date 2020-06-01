namespace E1
{
    public class Perro : Animales
    {
        public Perro(int energia):base(energia)
        {
        }

        public override int comer()
        {
            return energia+=15;
        }
        public override int jugar()
        {
            return energia-=20;
        }
    }
}