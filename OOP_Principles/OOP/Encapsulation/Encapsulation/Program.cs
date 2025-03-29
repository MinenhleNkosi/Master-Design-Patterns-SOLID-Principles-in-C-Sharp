namespace Encapsulation;

public class Program
{
    public static void Main(string[] args)
    {
        BadExample badExampleBalance = new BadExample();
        badExampleBalance.balance = 100;
        Console.WriteLine(badExampleBalance.balance);
        Console.ReadLine();
    }
}