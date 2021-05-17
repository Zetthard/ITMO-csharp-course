    using System;
	using System.IO;
/// <summary>
///    Class to create an upper case copy of a file
/// </summary>

public class CopyFileUpper
    {
		public static void Main()
		{
		string sFrom;
		string sTo;
		StreamReader srFrom;
		StreamWriter swTo;

		try
        {
			Console.WriteLine("Enter the input filename: ");
			sFrom = Console.ReadLine();
			Console.WriteLine("Enter the desired output filename: ");
			sTo = Console.ReadLine();
			srFrom = new StreamReader(sFrom);
			swTo = new StreamWriter(sTo);
			while (srFrom.Peek() != -1)
            {
				string sBuffer = srFrom.ReadLine();
				swTo.WriteLine(sBuffer.ToUpper());
			}
			srFrom.Close();
			swTo.Close();
		}
		catch(FileNotFoundException fnfEx)
        {
			Console.WriteLine("Could not find input file.", fnfEx);
        }
		catch(Exception ex)
        {
			Console.WriteLine(ex);
        }
		}       
    }
