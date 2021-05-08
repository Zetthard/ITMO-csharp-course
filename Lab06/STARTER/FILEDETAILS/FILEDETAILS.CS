
using System;                // Console
using System.IO;             // FileStream, FileReader
    
class FileDetails 
{
    static void Main(string[] args) 
	{
        // Console.WriteLine(args.Length);
        // foreach (string arg in args)
        //    Console.WriteLine(arg);
        string fileName = args[0];
		
		FileStream stream = new FileStream(fileName, FileMode.Open);
        StreamReader reader = new StreamReader(stream);
        long size = stream.Length;

        char[] contents = new char [size];
        for (int i = 0; i < size; i++)
            contents[i] = (char)reader.Read();

        // foreach (char element in contents)
        //     Console.Write(element);
        reader.Close();
        
        Summarize(contents);
        
    }

    static void Summarize (char[] args)
    {
        string vowels = "AEOUIaeoui";
        string consonants = "qwrtpsdfghkljzxcvbnmQWRTPSDFGHJKLZXCVBNM";
        int numberOfVowels = 0;
        int numberOfConsonants = 0;
        int numberOfLinebreaks = 0;

        foreach (char character in args)
        {
            if (vowels.IndexOf(character) != -1)
                numberOfVowels++;
                
            if (consonants.IndexOf(character) != -1)
                numberOfConsonants++;

            if (character == '\n')
                numberOfLinebreaks++;
        }

            Console.WriteLine("Total number of characters in file: " + args.Length);
            Console.WriteLine("Number of vowels in file: " + numberOfVowels);
            Console.WriteLine("Number of consonants in file: " + numberOfConsonants);
            Console.WriteLine("Number of lines in file: " + numberOfLinebreaks);
    }
}
