# Encapsulation
Encapsulation is a fundamental principle of object-oriented programming that involves bundling data and methods that operate on the data within a single unit, typically a class. In C#, encapsulation is typically implemented using:

- **🔒 Access modifiers**: public, private, protected, internal
- **🔧 Properties**: with getters and setters
- **🛠️ Methods**: that provide controlled access to internal data

<kbd>
  <img src="https://github.com/MinenhleNkosi/Master-Design-Patterns-SOLID-Principles-in-C-Sharp/blob/main/Images/1.png" height="800" width="1000" />
</kbd>

#### Benefits of Encapsulation:
- **🛡️ Data Protection**: Internal state is protected from unauthorized access.
- **✔️ Controlled Changes**: Data can be validated before modification.
- **🔐 Implementation Hiding**: Internal details can change without affecting client code.
- **📉 Reduced Complexity**: Users of the class see only what they need to see.

## 🚀 Getting Started

To explore OOP concepts in C#:
1. **📥 Install Visual Studio or Visual Studio Code**
2. **📂 Create a new C# Console Application**
3. **💻 Start implementing classes and exploring OOP principles**

<details>
<summary><strong>Code Example Explaination</strong></summary>
	
### Examination of Bad Practice in BadExample and Program.cs Files
- BadExample Class
Here is the BadExample class that is being used:
```cs
public class BadExample
{
    public decimal balance;
}
```

- In the Program.cs file, the usage of the BadExample class is as follows:
```cs
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
```
### Bad Practice Explanation
1. **Direct Access to Fields**: In the `BadExample` class, the `balance` field is declared as `public`. This allows any code outside of the `BadExample` class to directly access and modify the `balance` field. This is evident in the `Program.cs` file where `badExampleBalance.balance` is directly set and accessed.
```cs
badExampleBalance.balance = 100;
Console.WriteLine(badExampleBalance.balance);
```

2. **Violation of Encapsulation Principle**: Encapsulation is a fundamental principle of object-oriented programming that promotes restricting direct access to some of an object's components. This principle helps to prevent unintended interference and misuse of the object's internal state. By making the `balance` field public, the `BadExample` class violates this principle, leading to potential issues such as:

- Lack of control over the values assigned to `balance`.
- Difficulty in adding validation or additional logic when the `balance` is modified.
- Increased risk of bugs and maintenance challenges.

### Improved Version Using Encapsulation
1. Let's create a GoodExample class and we're actually now going to make the `balance` field private so that it can't be accessed outside of this class. 
  ```cs
  private decimal _balance;
  ```

2. Next let's actually create a **Constructor** now so that we can set the initial `balance` of the bank account and we'll say `decimal` `balance`.
   ```cs
   public BankAccount(decimal balance)
   {
       _balance = balance;
   }
   ```

3. What we're going to do now is we're going to provide a method called `deposit` and then we can set the balance in here. Let's create a method called `deposit` and we pass this an `amount` that we want to deposit and then what we can do is we can check that if the `amount` that we're trying to deposit is negative then we can `throw an error` because it doesn't make any sense to deposit a negative `amount` of money. You don't deposit **-R50** into a bank account. You only deposit positive numbers so we can say if `amount` is *less than or equal to zero* then we're going to throw a new argument exception and we will say that deposit amount must be positive so deposit `amount` must be positive okay so that is preventing now users of this class from depositing negative amounts of money.
   ```cs
   public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be positive");
        }


        _balance += amount;
    }
   ```
   
That actually solves our issue of having a negative `balance` because we now can't have a negative balance when we deposit money, okay so what we can do now is just add the `amount` onto the balance so we can say `this. balance` plus equals the `amount`.

4. So let's also create a method for *withdrawing* money from the bank account so currently we can *deposit* money but we also need to get money from the `account`. So let's create a `withdraw` method so we can say `public void withdraw`, and then we need to provide an amount that we want to withdraw now again we need to make sure that `balance` can't be negative and so we need to make sure we don't try to **withdraw** an amount greater than our `balance` so first of all we can check if the amount is less than zero so we can't **withdraw** a negative amount because that doesn't make any sense so we're going to say `if amount is less than or equal to zero`:
```cs
public void Withdraw(decimal amount)
{
  if (amount <= 0)
  {
      throw new ArgumentException("Withdrawal amount must be positive");
  }


  if (amount > balance)
  {
      throw new InvalidOperationException("Insufficient funds");
  }


  _balance -= amount;
}
```
 Then we're going to `throw` a `new argument exception` and we'll say withdrawal amount must be positive and we also need to check to see if the amount that we're trying to withdraw is greater than the amount that we have in the account because that shouldn't be possible so we're going to say `if amount is greater than the balance` then we can `throw invalid operation exception` and we can say insufficient funds otherwise if we get down to here.

5. Then we can just subtract the amount from the `balance` so we can say this do `balance` minus equals the amount okay and it would also be nice to, for the user to be able to actually see what their balance is so let's provide a `getter` method so a `getter` method is just a method that essentially allows the user to see a `private` value of a `private` field so we can say `public decimal` and then by convention what you do is you just basically prefix get onto the name of the field that we're trying to get so we say get `balance` and we're just going to return the `balance`
```cs
public decimal GetBalance()
{
  return _balance;
}
```

6. So now let's take a look at how we would use this new GoodExample class where we have **encapsulated** the logic and the fields within this class and not made them available publicly to all users of this class.
```cs
public class GoodExample
{
    private decimal _balance;


    public BankAccount(decimal balance)
    {
        _balance = balance;
    }


    public decimal GetBalance()
    {
        return _balance;
    }


    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Deposit amount must be positive");
        }


        _balance += amount;
    }


    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Withdrawal amount must be positive");
        }


        if (amount > _balance)
        {
            throw new InvalidOperationException("Insufficient funds");
        }


        _balance -= amount;
    }
}
```

7. So we're going to first of all modify our `Program` class:
```cs
public static void Main(string[] args)
{
    //For bad example demonstration
    BadExample badExampleBalance = new BadExample();
    badExampleBalance.balance = 100;

    //For good example demonstration
    GoodExample goodExampleBalance = new GoodExample(100);
    Console.WriteLine(goodExampleBalance.GetBalance);

    goodExampleBalance.Deposit(5);
    Console.WriteLine(5);
    
    goodExampleBalance.Withdraw(200);
    Console.WriteLine(goodExampleBalance.GetBalance);
    Console.ReadLine();
}
```
</details>
