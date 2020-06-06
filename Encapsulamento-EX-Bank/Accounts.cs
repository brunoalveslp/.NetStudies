
namespace Encapsulamento_ex_banco
{
    class Accounts
    {
        public int Account { get; private set; }
        public string Name { get; set; }
        public double Balance { get; private set; }

        public Accounts(int account, string name)
        {
            Account = account;
            Name = name;
            Balance = 0;
        }

        public Accounts(int account, string name ,double balance) : this(account, name)
        {
            Balance = balance;
        }


        public void deposit(double deposit)
        {
             Balance += deposit;
        }

        public void withdraw(double withdraw)
        {
            Balance -= withdraw + 5.0;
        }

        public override string ToString()
        {
            return $"Conta: {Account}, Titular: {Name}, Saldo: {Balance,8:c}";
        }


    }
}
