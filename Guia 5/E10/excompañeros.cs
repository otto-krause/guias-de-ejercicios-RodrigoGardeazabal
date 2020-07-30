namespace E10
{
    public class excompañeros
    {
        int idiomas;
        int ganancias;
        int paises;
        
        public excompañeros(int idiomas, int ganancias, int paises)
        {
            this.idiomas = idiomas;
            this.ganancias = ganancias;
            this.paises = paises;
        }

        public int Idiomas { get => idiomas; set => idiomas = value; }
        public int Ganancias { get => ganancias; set => ganancias = value; }
        public int Paises { get => paises; set => paises = value; }
    }
}