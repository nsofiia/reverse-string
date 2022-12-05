using System.Linq;

namespace reverse_string;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, I'll reverse anything you say: ");

        string initialInput = Console.ReadLine().ToLower();
        int lastIndex = initialInput.Length - 1;
        bool isPalindrome = true;

        for (int index = lastIndex; index > -1; index--)
        {
            Console.Write(initialInput[index]);
            if (initialInput[index] != initialInput[lastIndex - index])
            {
                isPalindrome = false;
            }
        }
        if (isPalindrome)
        {
            Console.WriteLine("\nThis is a Palindrome");
        }
        Console.ReadLine();
    }
}