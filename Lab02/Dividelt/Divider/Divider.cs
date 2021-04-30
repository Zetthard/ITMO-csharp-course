using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divider
{
    class Divider
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите первое число: ");
                String s1 = Console.ReadLine();
                Console.Write("Введите второе число: ");
                String s2 = Console.ReadLine();
                int a = int.Parse(s1);
                int b = int.Parse(s2);
                int k = a / b;
                Console.WriteLine("Результат деления {0} на {1}: {2}", s1, s2, k);
            }
            catch(Exception e)
            {
                Console.WriteLine("Произошла досадная ошибка: {0}", e);
            }
        }
    }
}
