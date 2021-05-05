namespace Utils
{
    using System;

    /// <summary>
    ///   This is the test harness
    /// </summary>

    public class Test
    {
        public static void Main()
        {
            // Request two numbers and print greater of them
            int x = 0, y = 0;
            Console.WriteLine("Please input first number: ");
            try
            {
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Please input second number: ");
                y = int.Parse(Console.ReadLine());

                //Test Swap method
                Console.WriteLine("Before swap: x = {0}, y = {1}", x, y);
                Utils.Swap(ref x, ref y);
                Console.WriteLine("After swap: x = " + x + ", y = " + y);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e);
            }
            int greater = Utils.Greater(x, y);
            Console.WriteLine("The greatest number is {0}", greater);
                        
            // Test Factorial
            bool ok;
            int f;
            Console.WriteLine("Please input natural number for factorial calculation: ");
            x = int.Parse(Console.ReadLine());
            ok = Utils.Factorial(x, out f);
            if (ok)
                Console.WriteLine("Factorial of " + x + " = {0}", f);
            else
                Console.WriteLine("Overflow error");
        }
    }
}
