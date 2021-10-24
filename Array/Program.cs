using System;
namespace Array
{
    class Program
    {
        public static string[] contentOFfile = System.IO.File.ReadAllLines(@"C:\Users\Hybr1\OneDrive\Desktop\COMP6052102 Data structures and algorithms\Array\Numbers.txt");
        public static void Main(string[] args)
        {
            try
            {
                int Count = 0;
                foreach (string line in contentOFfile)
                {
                    int i = Convert.ToInt32(line); // How to verify the object is a int accepted else throw exeption
                    Count++; //Display objects up to first 20
                    if (Count <= 20) // not sure if you want exaclly 20 or anything up to 20
                    {
                        Console.WriteLine(i);
                    }
                }
                primeNum();
            }
            catch (FormatException) // If format is wronf type
            {
                Console.WriteLine("The input should be numeric only 1 per line");
            }
            catch (OverflowException) // If number is above/below what 32 bit can handle
            {
                Console.WriteLine("A overflow has been detected please keep numbers for 32 bit");
            }
            catch // For unkown errors (an all catch)
            {
                Console.WriteLine("An unidentified error has occured");
            }
        }
        public static void primeNum() // all error's should appear before this function
        {
            int Count = 0;
            foreach (string line in contentOFfile)
            {
                int fileNum = 0;
                int j = 0;
                fileNum = Convert.ToInt32(line);
                if (fileNum < 2)
                {
                    fileNum = 4; // Converts any number lower than 2 in 4(none prime) dirty method
                }
                int m = fileNum / 2; // Divids the number to prime check by 2
                for (int i = 2; i <= m; i++)
                {
                    if (fileNum % i == 0) // Causes instant break if remainder is 0 due to even number (Even numbers cannot be prime other than 2)
                    {
                        j = 1; // False
                        break;
                    }
                }
                if (j == 0) // True
                {
                    Count++;
                }
            }
            Console.WriteLine("The ammount of prime numbers are: " + Count);                
        }
    }
}
