namespace ConsoleApp13;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter string: ");
        string text = Console.ReadLine();

        Console.WriteLine("press 1 to reverse string");
        Console.WriteLine("press 2 to change character in a string ");

        string input = Console.ReadLine();

        switch (input)
        {
            case "1":
                string reverseString = ReverseString(text);
                Console.WriteLine($"Reverse of {text} is {reverseString}");
                break;
            case "2":
                ChangeCharacter(text);

                break;
            default:
                Console.WriteLine("Exit");
                break;
        }
    }

    public static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    public static void ChangeCharacter(string str)
    {
        Console.Write("Enter character you want to change and character replace with: ");
        char preCh = Convert.ToChar(Console.Read());
        char newCh = Convert.ToChar(Console.Read());
        string newString = "";
        foreach (char ch in str)
        {
            if (ch == preCh)
            {
                newString += newCh;
            }
            else
            {
                newString += ch;
            }
        }
        Console.WriteLine($"\nold string: {str} => new string: {newString}");
    }
}