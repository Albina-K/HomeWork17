using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork17
{
    /// <summary>
    /// тариф Обычный
    /// </summary>
    public class OrdinaryAccount : ICalculator
    {
        public double Balance { get; set; }
        public double Interest { get; set; }
        public OrdinaryAccount(double balance)
        {
            Balance = balance;
        }
        public void CalculatorInterest()
        {
            Console.WriteLine("Ваш тариф - обычный");
            if (this.Balance < 1000) 
                this.Interest -= this.Balance  * 0.2;

            if (this.Balance >= 1000)
                this.Interest -= this.Balance * 0.4;
            Console.WriteLine($"Ваш баланс: {this.Balance}, Ваша процентная ставка: {this.Interest}");
        }
    }
}
