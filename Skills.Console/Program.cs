using System;

namespace Skills.Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What size of array would you like to sort?");
            var userInput = Console.ReadKey();

            int size;
            if (char.IsDigit(userInput.KeyChar))
            {
                size = int.Parse(userInput.KeyChar.ToString());
            }
            else
            {
                size = 0;
            }

            Console.ReadKey();
        }
    }
}
