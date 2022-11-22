using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое целое число");
            try
            {
                double i = int.Parse(Console.ReadLine());
                int x = 5;
                double y = x / i;
                Console.WriteLine($"{x}/{i}={y}");
            }
            catch
            {
                Console.WriteLine("Неправильный ввод значения");
            }
            finally
            {
                Console.WriteLine("Выполнен блок finally");
            }
                Console.ReadLine();
        }
    }
}
