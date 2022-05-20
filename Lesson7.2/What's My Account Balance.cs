using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7._2
{
    // Данная программа получает номер счета и его баланс в качестве вводных данных
    // Она определяет класс Account с одним членом balance и наследует из него класс User
    // с одним дополнительным членом - номером аккаунта (AccNumber),
    // затем создает объект user и пытается сохранить в нем баланс и номер счета,
    // а так же отображает банковские данные
    // Исправить программу таким образом, чтобы она завершала работу конструктора User(),
    // который должен присваивать параметры соответствующим членам класса User

    internal class Program
    {
        static void Main(string[] args)
        {
            string accNumber = Console.ReadLine();
            double balance = Convert.ToDouble(Console.ReadLine());

            User user = new User(accNumber, balance);

            user.ShowDetails();
            Console.ReadKey();
        }
    }

    class Account
    {
        protected double Balance { get; set; }
    }

    class User : Account
    {
        public string AccNumber { get; set; }

        public User(string accNumber, double balance)
        {
            AccNumber = accNumber;
            Balance = balance;
        }

        public void ShowDetails()
        {
            Console.WriteLine("Account: " + AccNumber);
            Console.WriteLine("Balance: " + Balance);
        }
    }
}
