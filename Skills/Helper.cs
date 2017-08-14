using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skills
{
    public static class Helper
    {
        /// <summary>
        /// Generates a random integer from 1 to maxNumber
        /// </summary>
        /// <param name="maxNumber"></param>
        /// <returns></returns>
        public static int generateNumber(int maxNumber)
        {
            Random random = new Random();
            int generatedInt = Convert.ToInt32(random.NextDouble() * maxNumber) + 1;

            return generatedInt;
        }

        /// <summary>
        /// Generates an array of given size with random numbers between 1 and maxNumber
        /// </summary>
        /// <param name="size"></param>
        /// <param name="maxNumber"></param>
        /// <returns></returns>
        public static int[] generateRandomArray(int size, int maxNumber)
        {
            int[] generatedArray = new int[size];

            for (int i=0; i < generatedArray.Length; i++)
            {
                generatedArray[i] = generateNumber(maxNumber);
            }

            return generatedArray;
        }
    }
}
