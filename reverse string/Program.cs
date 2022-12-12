using System.Linq;

namespace reverse_string;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, I can reverse anything!\n"); //prints at the beggining of the game

        while (true) //loop if player wants to try again
        {
            Console.WriteLine("Type in the word and press enter:\n");
            string initialInput = Console.ReadLine().ToLower();
            int lastIndex = initialInput.Length - 1; //last index from input needed to start printing from the end
            bool isPalindrome = true; //assuming it is a palindrome and then check in line 20

            for (int index = lastIndex; index > -1; index--) //starting from the last index and print each letter untill index is more than -1
            {
                Console.Write(initialInput[index]); //displaying the reversed order character by character
                if (initialInput[index] != initialInput[lastIndex - index]) // palindrome check - if letter from the end not equal to letter from the beginning
                {
                    isPalindrome = false; //when at least 1 letter is not equal - isPalindrome switches to false
                }
            }
            if (isPalindrome) //if palindrome check kept valie as true - it is a palindrome 
            {
                Console.WriteLine("\n\nYay, found a Palindrome!");
            }

            Console.WriteLine("\n\nTry another word? \ny - to restart; \npress any other key to exit\n"); //another try prompt
            char answer = Char.ToLower(Console.ReadKey().KeyChar);
            if (answer=='y') 
            {
                Console.Clear();
                continue; // start loop again
            }
            else
            {
                return; //exit
            }
        }
    }
}