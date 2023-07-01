using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {

        static string ReverseString(string input)
        {
            if(input.Length <= 1) // When input is not long enough. There will not be reversal since it is the same.
            {
                return input; // Returns the same value.
            }

            char[] ch = new char[input.Length]; // Creating an array which is same length as input.
            ch = input.ToCharArray(); // Converts string input to Char Array and assigning to a variable.
            char[] newString = new char[input.Length]; // Creating an array which will contain the Reversed String's characters as an array.
            int i= 0; // Pointer 1.
            int n = input.Length - 1; // Pointer 2. Since it will be out of bounds. 'n' has to be - 1.

            while (i <= n) // When they are equal they will meet in the middle. And they should not continue anymore.
            {
                newString[i] = ch[n]; // Starting to create the new array from the first element to the middle.
                newString[n] = ch[i]; // Creating the new array from the last element to the middle.
                i++; // incrementing the Pointer 1.
                n--; // decrementing the Pointer 2.
            }
            return new string(newString); // Converting the reversed character array to string again.
        }
        static void Main(string[] args)
        {
            Console.Write("Please enter a word: "); // Asking to user put in to input.
            string word = Console.ReadLine(); // Assigning input to a variable.

            while(word.All(char.IsLetter) == false) // Checking the input's every character if they are letter or not.
            {
                
                Console.Write("Invalid input. Please enter a word: "); // Error message.
                word = Console.ReadLine(); // This line allows the user to input a word again after an error
            }

            string NewWord = ReverseString(word); // Assigning the function to a variable.

            if(word.Length <= 1) 
            {
                Console.WriteLine("No reversal needed. The word remains unchanged: " + NewWord); // Output if word's length less than 1.
            }
            else
            {
                Console.WriteLine("Reversed Word is: " + NewWord); // Output if everything is okay.
            }
            Console.ReadLine();
        }
    }
}
