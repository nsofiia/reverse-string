using System.Linq;

namespace reverse_string;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, I'll reverse anything you say: ");
        string initialInput = Console.ReadLine().ToLower();
        int palindromeCount = 0;
        int actualIndex = 0;

        for (int index = initialInput.Length - 1; index > -1; index--)
        {
            Console.Write(initialInput[index]);
            if (initialInput[index] == initialInput[actualIndex])
            {
                actualIndex++;
                palindromeCount++;
            }

            if (palindromeCount == initialInput.Length)
            {
                Console.WriteLine("\nPalindrome");
            }
        }
        Console.ReadLine();
    }
}

