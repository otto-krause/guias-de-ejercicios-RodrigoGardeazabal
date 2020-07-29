namespace E4
{
    public class Medico
    {
        string nombre, apellido, especialidad;
        int turnos;

        public Medico(string nombre, string apellido, string especialidad, int turnos)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.especialidad = especialidad;
            this.turnos = turnos;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
        public int Turnos { get => turnos; set => turnos = value; }
        public bool Estadisponible()
        {
            return Turnos<50;
        }
    }
}