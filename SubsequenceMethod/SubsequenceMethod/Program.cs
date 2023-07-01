using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubsequenceMethod
{
    class Program
    {
        static int IncreasingSubsequence(int[] inputArray)
        {
            int count = 1;
            int maxLength = 1;
            int i;
            for(i = 0; i < inputArray.Length - 1; i++)
            {
                if(inputArray[i + 1] > inputArray[i])
                {
                    count++;
                    if(count > maxLength)
                    {
                        maxLength = count;
                    }
                }
                else
                {
                    count = 1;
                }

                
            }
            return maxLength;

        }

        static void Main(string[] args)
        {
            Console.Write("Please enter the size of your array: ");
            int sizeOfArray;
            while (!int.TryParse(Console.ReadLine(), out sizeOfArray) || sizeOfArray <= 1)
            {
                Console.Write("Size of your array is not long enough try to input longer array: ");
            }

            int[] array = new int[sizeOfArray];

            for(int i = 0;i < sizeOfArray; i++){
                Console.Write("Please enter {0} element of your array: ", i + 1);
                while (!int.TryParse(Console.ReadLine(), out array[i])){
                    Console.Write("Invalid input. Please enter a valid integer: ");
                }

            }

            int longestIncreasingSubsequence = IncreasingSubsequence(array);

            Console.WriteLine("The longest increasing subsequence in your array is: " + longestIncreasingSubsequence);
            Console.ReadLine();
        }
    }
}
