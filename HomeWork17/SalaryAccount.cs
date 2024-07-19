using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork17
{
    /// <summary>
    /// тариф Зарплатный
    /// </summary>
    public class SalaryAccount : ICalculator
    {
        public double Balance { get; set; }
        public double Interest { get; set; }
        public SalaryAccount(double balance)
        {
            Balance = balance;           
        }
        public void CalculatorInterest()
        {
            Console.WriteLine("Ваш тариф - зарплатный");
            this.Interest = this.Balance * 0.5;
            Console.WriteLine($"Ваш баланс: {this.Balance}, Ваша процентная ставка: {this.Interest}");
        }
    }
}
