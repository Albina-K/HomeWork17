using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork17
{
    /// <summary>
    /// общий клас для реализации расчета тарифов
    /// </summary>
    public class Calculator
    {
        public void Calculation(ICalculator calculator)
        {
            calculator.CalculatorInterest();
        }
    }
}
