using System;
using Skills;
using System.Linq;
using System.Collections.Generic;

namespace Skills.Program
{
    class Program
    {
        static void Main(string[] args)
        { 
            var getValue = new Func<string, int>(caption =>
            {
                int value;
                string input;
                do
                {
                    Console.WriteLine(caption);
                    input = Console.ReadLine();
                    Console.WriteLine();
                } while (!int.TryParse(input, out value));

                return value;
            });

            int arraySize = getValue("What size of array would you like to sort?");
            int maxValue = getValue("What would you like to be the max value inside the array?");

            string getSortTypeCaption = "Choose the sorting type:";
            var sortTypes = Enum.GetValues(typeof(ESortType));
            foreach (var value in sortTypes)
            {
                getSortTypeCaption += "\n" + value + ": " + Convert.ToInt32(value);
            }
            Console.WriteLine(getSortTypeCaption);
            ConsoleKeyInfo userInput = Console.ReadKey();
            Console.WriteLine();
            int sortType;
            ESortType sortTypeEnum;
            if (int.TryParse(userInput.KeyChar.ToString(), out sortType) && Enum.TryParse<ESortType>(sortType.ToString(), out sortTypeEnum))
            {
                var generatedArray = Helper.generateRandomArray(arraySize, maxValue);
                Console.WriteLine("Generated array: " + string.Join(", ", generatedArray));
                IList<int> sortedArray = null;
                var a = DateTime.Now;
                switch (sortTypeEnum)
                {
                    case ESortType.TreeSort:
                        sortedArray = Sorting.treeSort(generatedArray);
                        break;
                    case ESortType.QuickSort:
                        sortedArray = Sorting.quickSort(generatedArray);
                        break;
                }
                var b = DateTime.Now;
                Console.WriteLine("Sorted array: " + string.Join(", ", sortedArray));
                Console.WriteLine("Time to sort: "+ (b - a).TotalMilliseconds + " milliseconds");
            }
            else
            {
                Console.WriteLine("invalid option");
            }

            Console.ReadKey();
        }
    }
}
