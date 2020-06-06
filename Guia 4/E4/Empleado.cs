namespace E4
{
    public abstract class Empleado
    {
        protected int cajabancaria;

        public Empleado()
        {
            this.cajabancaria =0;
        }

        public abstract void depositar(string tipo);
        public abstract void extraer(int extraccion);
    }
}