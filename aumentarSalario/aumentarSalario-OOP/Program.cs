using System;
using System.Globalization;

namespace aumentarSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();
            PorCent p = new PorCent();

            Console.Write("nome: ");
            f.nome = Console.ReadLine();
            Console.Write("salario: ");
            f.salario = double.Parse(Console.ReadLine());
            Console.Write("imposto: ");
            f.imposto = double.Parse(Console.ReadLine());
            double semImp = f.salario - f.imposto;
            Console.WriteLine("O funcionario :" + f.nome + ", $" + semImp);
            Console.Write("Porcentagem de Aumento: ");
            p.pc = double.Parse(Console.ReadLine());

            double aumento = (f.salario / 100) * p.pc + semImp;
            Console.Write("Salario final: " + aumento);



        }
    }
}
