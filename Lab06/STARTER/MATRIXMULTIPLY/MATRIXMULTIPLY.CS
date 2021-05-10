
using System;

class MatrixMultiply {
    static void Main() 
    {
        int[,] arrayOne = new int[2, 2];
        int[,] arrayTwo = new int[2, 2];

        Input(arrayOne);
        Input(arrayTwo);
        int[,] resultArr = Multiply(arrayOne, arrayTwo);

        Output(resultArr);

        Console.ReadKey();
    }

    static void Input(int[,] dst)
    {
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write("Please enter the [{0}, {1}] element of the array: ", i, j);
                string s = Console.ReadLine();
                dst[i, j] = int.Parse(s);
            }
        }
    }

    static void Output(int[,] resultArr)
    {
        Console.WriteLine();  // Print an empty line before method output to separate text from previous lines
        for (int i = 0; i < resultArr.GetLength(0); i++)
        {
            for (int j = 0; j < resultArr.GetLength(1); j++)
            {
                Console.Write("{0} ", resultArr[i, j]);
            }
            Console.WriteLine();
        }
    }

    static int[,] Multiply(int[,] a, int[,] b)
    {
        int[,] result = new int[2, 2];
        for (int r = 0; r < 2; r++)
        {
            for (int c = 0; c < 2; c++)
                result[r, c] = a[r, 0] * b[0, c] + a[r, 1] * b[1, c];
        }
        return result;
    }
}
    
