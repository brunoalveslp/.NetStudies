using System;
using System.Globalization;

namespace Encapsulamento_ex_banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Accounts conta;

            Console.WriteLine("----------------------------------------------------------");
            Console.Write("Entre Com o numero da conta: ");
            int Numero = int.Parse(Console.ReadLine());
            Console.Write("Entro o Titular da conta: ");
            string Nome = Console.ReadLine();
            Console.Write("Havera deposito inicial? (s/n)");
            char res = char.Parse(Console.ReadLine());
            if (res =='s' || res == 'S')
            {
                Console.Write("Quantia a ser Depositada: ");
                double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Accounts(Numero, Nome, deposito);
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("Dados da Conta: ");
                Console.WriteLine(conta);
            } else
            {
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Dados da Conta: ");
                conta = new Accounts(Numero, Nome);
                Console.WriteLine(conta);
            }
            Console.WriteLine("--------------------------------------------------------");
            Console.Write("Entre com um valor para Deposito: ");
            double deposit = double.Parse(Console.ReadLine());
            conta.deposit(deposit);
            Console.WriteLine("Dados Atualizados da Conta: ");
            Console.WriteLine(conta);
            Console.WriteLine("--------------------------------------------------------");
            Console.Write("Entre com um valor para Saque: ");
            double withdraw = double.Parse(Console.ReadLine());
            conta.withdraw(withdraw);
            Console.WriteLine("Dados Atualizados da Conta: ");
            Console.WriteLine(conta);
            Console.WriteLine("-------------------------------------------------------");


        }
    }
}
