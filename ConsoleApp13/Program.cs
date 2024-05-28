namespace ConsoleApp13;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter string: ");
        string text = Console.ReadLine();
        string reverseString = ReverseString(text);
        Console.WriteLine($"Reverse of {text} is {reverseString}");
    }

    public static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}