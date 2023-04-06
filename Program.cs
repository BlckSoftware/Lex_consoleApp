using System;
using System.IO;
using System.Linq;

namespace Lex_consoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(@"  
             ________________________________________________
            /                                                \
           |    _________________________________________     |
           |   |                                         |    |
           |   |                  Lex                    |    |
           |   |                                         |    |
           |   |                 Console                 |    |
           |   |                                         |    |
           |   |               Application               |    |    
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |           github.com/BlckSoftware       |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |                                         |    |
           |   |_________________________________________|    |
           |                                                  |
           |        created by -- > Huseyin Karayazim         |
            \_________________________________________________/
                   \___________________________________/
                ___________________________________________
             _-'    .-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.  --- `-_
          _-'.-.-. .---.-.-.-.-.-.-.-.-.-.-.-.-.-.-.--.  .-.-.`-_
       _-'.-.-.-. .---.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-`__`. .-.-.-.`-_
    _-'.-.-.-.-. .-----.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-----. .-.-.-.-.`-_
 _-'.-.-.-.-.-. .---.-. .-------------------------. .-.---. .---.-.-.-.`-_
:-------------------------------------------------------------------------:
`---._.-------------------------------------------------------------._.---'
");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("\n\nEnter the file path for the text file:");
            string filePath=Console.ReadLine();
            Console.WriteLine("\n\n");
            GetLinesCount(filePath);
            GetLettersCount(filePath);
            GetSpaceCount(filePath);
            GetWordsCount(filePath);
            GetVowelsAndConsonantsCount(filePath);
            Console.WriteLine("\nPress Any Key For Exit");
            Console.ReadLine();
           
        }
        public static void GetLinesCount(string fileName) 
        {

            int lineCount = 0;

            using (var reader = new StreamReader(fileName))
            {
                while (reader.ReadLine() != null)
                {
                    lineCount++;
                }
            }

            
            Console.WriteLine("Line Count = "+lineCount);

        }
        public static void GetLettersCount(string fileName)
        {
            int letterCount = 0;

            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    foreach (char c in line)
                    {
                        letterCount++;
                    }
                }
            }

            Console.WriteLine("Letters Count = " +letterCount);
        }
        public static void GetSpaceCount(string fileName)
        {
            int spaceCount = 0;
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    spaceCount += line.Count(char.IsWhiteSpace);
                }
            }
            Console.WriteLine("Line Count = " + spaceCount);
        }
        public static void GetWordsCount(string filePath)
        {
            int wordCount = 0;
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] words = line.Split(new char[] { ' ', '.', ',', ';', ':', '-', '!', '?', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
                        wordCount += words.Length;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            Console.WriteLine("Words Count = "+wordCount);
        }
        public static void  GetVowelsAndConsonantsCount(string filePath)
        {
            string text = File.ReadAllText(filePath);
            int vowelCount = 0, consonantCount = 0;
            foreach (char c in text)
            {
                if (Char.IsLetter(c))
                {
                    if ("aeiouAEIOU".IndexOf(c) != -1)
                        vowelCount++;
                    else
                        consonantCount++;
                }
            }

            Console.WriteLine("Vowel Count = "+vowelCount  +" | Consonant Count = "+consonantCount);
           
        }


    }
}
