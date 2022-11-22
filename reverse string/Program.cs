namespace reverse_string;
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello, I'll reverse anything you say: ");

        string x = Console.ReadLine();

        int y = x.Length-1;

        char[] a = x.ToCharArray();

        char[] b = {};

        do
        {
            Console.WriteLine(a[y]);
            b.Append(a[y]);
            y--;
        } while (y > -1);

        Console.ReadLine(b);


        if (a == b)
        {
            Console.WriteLine("This is polindrome!");
        }
        Console.ReadKey(true);
    }
}

