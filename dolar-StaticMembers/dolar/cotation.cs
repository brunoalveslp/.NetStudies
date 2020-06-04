
namespace dolar
{
    class Cotation
    {
        public static double dolar;
        public static double qnt;
        
        public static double cot()
        {
            double x = qnt * dolar;
            double fin = (x / 100) * 6 + x;
            return fin;

        }


    }
}
