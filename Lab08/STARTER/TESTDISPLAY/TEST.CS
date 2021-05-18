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
            int intVal = 5;
            string strVal = "five";
            Coordinate cVal = new Coordinate(66.0, 30.0);
            Utils.Display(intVal);
            Utils.Display(strVal);
            Utils.Display(cVal);
            Console.ReadKey();
        }
    }
}
