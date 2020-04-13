namespace E5
{
    public class Triangulo
    {
        public bool EsEscaleno(int opc)
        {
            return opc==3;
        }
        public bool EsIsosceles(int opc)
        {
            return opc==2;
        }
        public bool EsEquilatero(int opc)
        {
            return opc==1;
        }
        public bool EsTrianguloRectangulo(int esequi)
        {
            return esequi==1;
        }
    }
}