namespace Utils
{
    using System;

    public class Utils
    {
        public static int Greater(int a, int b)
        {
            int max;
            if (a > b)
                max = a;
            else
                max = b;
            return max;
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static bool Factorial(int n, out int answer)
        {
            int k;
            int f = 1;
            bool ok = true;
            try
            {
                checked
                {
                    for (k = 2; k <= n; k++)
                        f *= k;
                }
                
            }
            catch (OverflowException e)
            {
                f = 0;
                ok = false;
                Console.WriteLine("Checked and caught: " + e);
            }
            answer = f;
            return ok;
        }
    }
}
