using System;

namespace Lab2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate calculate = delegate (int a, int b, int c)
            {
                Console.WriteLine("Среднее арифметическое: " + ((a + b + c) / 3).ToString());
                return;
            };
            calculate(12, 6, 4);
        }

        delegate void Calculate(int a, int b, int c);
    }
}
