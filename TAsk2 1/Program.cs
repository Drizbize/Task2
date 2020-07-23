using System;
using System.Linq;

namespace ConsoleApp1csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sampleArray = new int[] { 3, 6, 2, 7, 8 };

            // initializing array from another array
            int[] numbersRichard = sampleArray.ToArray();
            int[] numbersMisha = sampleArray.ToArray();

            // TODO: write your implementation of sort algorithm
            int temp;
            for (int i = 0; i < sampleArray.Length - 1; i++)
            {
                for (int j = i + 1; j < sampleArray.Length; j++)
                {
                    if (sampleArray[i] > sampleArray[j])
                    {
                        temp = sampleArray[i];
                        sampleArray[i] = sampleArray[j];
                        sampleArray[j] = temp;
                    }
                }
            }
            // below you can find the same functional, but another implementation
            // try to use already written functions as much as possible
            Array.Sort(numbersMisha);
            PrintArray("Sample Array", sampleArray);
            PrintArray("Misha array", numbersMisha);
            PrintArray("Richard array", numbersRichard);
            for (int i = 0; i < sampleArray.Length; i++)
            {                
                Console.Write(sampleArray[i]);
                Console.Write(" ");
            }
            Console.ReadKey();
        }

        static void PrintArray(string title, int[] array)
        {
            Console.WriteLine(title);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
