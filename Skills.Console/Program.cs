using System;
using Skills;

namespace Skills.Program
{
    class Program
    {
        static void Main(string[] args)
        {
            var getValue = new Func<string, int>(caption => {
                ConsoleKeyInfo userInput;
                do
                {
                    Console.WriteLine(caption);
                    userInput = Console.ReadKey();
                    Console.WriteLine();
                } while (!char.IsDigit(userInput.KeyChar));
                
                return int.Parse(userInput.KeyChar.ToString());
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
            

            Console.ReadKey();
        }
    }
}
