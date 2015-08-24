using System;

namespace HW_logic
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary = 22546.8;
            Console.WriteLine(BonusCalculator.CalculateBonus(salary, 15));
            Console.ReadKey();
        }
    }
}
