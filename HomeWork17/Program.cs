namespace HomeWork17
{
    class Program
    {
        static void Main (string[] args)
        {
            var calculator = new Calculator();
            calculator.Calculation(new OrdinaryAccount(1300));

            Console.WriteLine();

            var calculator2 = new Calculator();
            calculator2.Calculation(new SalaryAccount(100));
        }
    }
}
