namespace src;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("1 son kiriting: ");
        var number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("2 son ketring: ");
        var number2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("(+, -, *, /): ");
        string abc = Console.ReadLine(); // shotda (char abs = Console.ReadLine();) ishlatsa boladimi?

        if (abc == "+")
        {
            Console.WriteLine(number1 - number2);
        }
        else if (abc == "-")
        {
            Console.WriteLine(number1 - number2);
        }
        else if (abc == "*")
        {
            Console.WriteLine(number1 - number2);
        }
        else if (abc == "/")
        {
            Console.WriteLine(number1 - number2);
        }
        else
        {
            Console.WriteLine("Notog'ri amal!");
        }
    }
}
