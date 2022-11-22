using System.Linq;

namespace reverse_string;
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello, I'll reverse anything you say: ");
        string initialInput = Console.ReadLine();//get input
        int iterationsToReverse = initialInput.Length - 1;//ammount of iterations depends on the ammount of characters in the input
        List<string> reversedInputList = new List<string> { };//list to collect reversed input frm the loop
        Console.Write("reversed:");
        do
        {
            Console.Write(initialInput[iterationsToReverse]);//prints string starting from the last index of input
            reversedInputList.Add(initialInput[iterationsToReverse].ToString());//adding each printed above letter to the list 
            iterationsToReverse--;
        } while (iterationsToReverse > -1);
        string reversedInput = string.Join("", reversedInputList);//joining list into string
        if (initialInput == reversedInput) //comparing strings
        {
            Console.WriteLine("\nfound palindrome!");
        }
        Console.ReadKey(true);
    }
}