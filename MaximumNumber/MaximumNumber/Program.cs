using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumNumber
{
    class Program
    {

        static int FindMax(int[] numbers)
        {
            int maxNumber = numbers[0];
            foreach(int number in numbers) //foreach checks each element of array
            {
                if(number > maxNumber)
                {
                    maxNumber = number;
                }
            }
            return maxNumber;
        }
        static void Main(string[] args)
        {
            int i;
            Console.Write("Enter the size of your array: ");
            int sizeOfArray;
            while (!int.TryParse(Console.ReadLine(), out sizeOfArray) || sizeOfArray <= 0) // TryParse checks input for sizeOfArray if it is suitable (integer in this case) and other one is making sure it is not 0 or a negative number
            {
                Console.Write("Invalid number. Please write a positive integer: ");
            }

            int[] array = new int[sizeOfArray];

            for(i = 0; i < sizeOfArray; i++)
            {
                Console.Write("Please enter {0} element of your array: ", i + 1);
                while (!int.TryParse(Console.ReadLine(), out array[i])) // Same as before TryParse checking data type of each element of array
                {
                    Console.Write("Invalid number. Please enter an integer: ");
                }
            }

            int MaximumNumberOfArray = FindMax(array);
            Console.WriteLine("Max number of your array is: " + MaximumNumberOfArray);
            Console.ReadLine();
            
        }

    }
}
