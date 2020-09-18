using System;

namespace Lessons

{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Число А: ");
                double number1 = double.Parse(Console.ReadLine());
                Console.Write("Число Б: ");
                double number2 = double.Parse(Console.ReadLine());
                Console.Write("Число С: ");
                double number3 = double.Parse(Console.ReadLine());
                double B = number1;
                double C = number2;
                double A = number3;
                Console.WriteLine($"C = {C}");
                Console.WriteLine($"A = {A}");
                Console.WriteLine($"B = {B}");
            }
            catch
            {
                Console.WriteLine("Ошибка ввода данных!");
            }
        }
    }
}
