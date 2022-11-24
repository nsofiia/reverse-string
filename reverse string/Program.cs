using System.Linq;

namespace reverse_string;
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello, I'll reverse anything you say: ");
        string initialInput = Console.ReadLine();
        int iterationsToReverse = initialInput.Length - 1;
        string reversedStr = "";
        while (iterationsToReverse > -1)
        {
            reversedStr += initialInput[iterationsToReverse];
            iterationsToReverse--;
        }

        if (initialInput.ToUpper().Equals(reversedStr.ToUpper()))
        {
            Console.WriteLine("found palindrome");
        }
        Console.ReadKey(true);

    }
}