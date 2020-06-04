using System;
using System.Globalization;

namespace dolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotacao do Dolar: ");
            Cotation.dolar = double.Parse(Console.ReadLine());
            Console.Write("Quantos dolares voce vai comprar: ");
            Cotation.qnt = double.Parse(Console.ReadLine());
            Console.Write("Valor a ser pago = "+Cotation.cot().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
