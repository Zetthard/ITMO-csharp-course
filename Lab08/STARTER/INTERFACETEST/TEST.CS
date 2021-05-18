namespace Utils
{
    using System;

    /// <summary>
    ///   This the test harness
    /// </summary>

    public class Test
    {
        public static void Main() 
        {
            int intVal = 0;
            ulong longVal = 0;
            string strVal = "zero";
            Console.WriteLine("Int: {0}", Utils.IsItFormattable(intVal));
            Console.WriteLine("ulong: {0}", Utils.IsItFormattable(longVal));
            Console.WriteLine("String: {0}", Utils.IsItFormattable(strVal));
            Console.ReadKey();
        }
    }
}
