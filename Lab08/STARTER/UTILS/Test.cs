using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class Test
    {
        public static void Main()
        {
            string tempString;
            Console.WriteLine("Please enter the string you wish to reverse: ");
            tempString = Console.ReadLine();
            Utils.Reverse(ref tempString);
            Console.WriteLine(tempString);
            Console.ReadKey();
        }
    }
}
