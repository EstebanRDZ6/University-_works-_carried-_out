namespace AreasGeometricas.DLL
{
    public static class CalculoAreas
    {
        public static double Circulo(double radio)
        {
            return Math.PI * Math.Pow(radio, 2);
        }
        public static double Cuadrado(double lado)
        {
            return Math.Pow(lado, 2);
        }
        public static double Rectangulo(double ancho, double alto)
        {
            return ancho * alto;
        }
        public static double Triangulo(double LongBase, double alto)
        {
            return 0.5 * LongBase * alto;
        }


    }

}
