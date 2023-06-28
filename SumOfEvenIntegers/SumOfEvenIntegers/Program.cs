using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfEvenIntegers
{
    class Program
    {
        static int CalculateSumOfEvenNumbers(int[] array)
        {
            int sum = 0;
            foreach (int number in array)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the size of your array: ");
            int sizeOfArray;
            while (!int.TryParse(Console.ReadLine(), out sizeOfArray) || sizeOfArray <= 0)
            {
                Console.Write("Invalid input. Please enter a positive integer for the size of array: ");
            }

            int[] array = new int[sizeOfArray];

            for (int i = 0; i < sizeOfArray; i++)
            {
                Console.Write("Please enter element {0} of your array: ", i + 1);
                while (!int.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.Write("Invalid input. Please enter a valid integer for elements of array: ");
                }
            }

            int sumOfEvenNumbers = CalculateSumOfEvenNumbers(array);
            Console.WriteLine("Sum of the even numbers in the array: " + sumOfEvenNumbers);
            Console.ReadLine();
        }
    }
}
