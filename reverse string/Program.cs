using System.Linq;

namespace reverse_string;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, I'll reverse anything you say:\nenter a palindrome, to activate the palindrome detection feature");

        while (true)
        {
            Console.WriteLine("\nType in the word and press enter:\n");
            string initialInput = Console.ReadLine().ToLower();
            int lastIndex = initialInput.Length - 1;
            bool isPalindrome = true; //assuming that it is a palindrome and then check

            for (int index = lastIndex; index > -1; index--)
            {
                Console.Write(initialInput[index]); //displaying the reversed order character by character
                if (initialInput[index] != initialInput[lastIndex - index]) // palindrome check - if 1st letter = to last letter
                {
                    isPalindrome = false; //when at least 1 letter is not equal - it is not a palindrome
                }
            }
            if (isPalindrome) //if palindrome check kept valie as true - it is a palindrome 
            {
                Console.WriteLine("\nThis is a Palindrome");
            }

            Console.WriteLine("\nWould you like to try another word? y- restart; any other key to exit\n");
            char answer = Char.ToLower(Console.ReadKey().KeyChar);
            if (answer=='y')
            {
                continue;
            }
            else
            {
                return;
            }
        }
    }
}