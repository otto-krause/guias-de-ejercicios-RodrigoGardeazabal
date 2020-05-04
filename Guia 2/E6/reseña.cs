namespace E6
{
    public class reseña
    {
        string reseñas;
        int cal;
        public reseña(string reseñas, int cal)
        {
            this.reseñas=reseñas;
            this.cal=cal;
        }
        public string coment()
        {
            return reseñas;
        }
        public int cali()
        {
            return cal;
        }
    }
}