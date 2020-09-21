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
                double A = double.Parse(Console.ReadLine());
                Console.Write("Число Б: ");
                double B = double.Parse(Console.ReadLine());
                Console.Write("Число С: ");
                double C = double.Parse(Console.ReadLine());
                double ch = 0;
                ch = A;
                A = B;
                B = C;
                C = A;
                A = B;
                B = ch;
                Console.WriteLine($"A = {A}");
                Console.WriteLine($"B = {B}");
                Console.WriteLine($"C = {C}");
            }
            catch
            {
                Console.WriteLine("Ошибка ввода данных!");
            }
        }
    }
}
