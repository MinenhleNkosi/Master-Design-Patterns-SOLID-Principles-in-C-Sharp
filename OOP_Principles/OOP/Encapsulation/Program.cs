namespace Encapsulation;

public class Program
{
    public static void Main(string[] args)
    {
        #region Good Example
        //BadExample badExampleBalance = new BadExample();
        //badExampleBalance.balance = 100;
        //Console.WriteLine(badExampleBalance.balance);
        //Console.ReadLine();
        #endregion

        #region Good Example
        GoodExample goodExampleBalance = new GoodExample(500); //First we deposit 500
        Console.WriteLine(goodExampleBalance.GetBalance()); //Check the balance
        goodExampleBalance.Withdraw(200); //Then we Withdraw 200
        Console.WriteLine(goodExampleBalance.GetBalance()); //Check the balance
        Console.ReadLine();
        #endregion
    }
}