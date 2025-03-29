# Object-Oriented Programming in C#

## Overview
Object-Oriented Programming (OOP) is a programming paradigm that uses "objects" and classes to design and structure software applications. In C#, OOP is centered around organizing code into reusable, self-contained units called classes.

## Key OOP Principles

### 1. Encapsulation
Encapsulation is a fundamental principle of object-oriented programming that involves bundling data and methods that operate on the data within a single unit, typically a class. In C#, encapsulation is typically implemented using:

- **🔒 Access modifiers**: public, private, protected, internal
- **🔧 Properties**: with getters and setters
- **🛠️ Methods**: that provide controlled access to internal data

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
To adhere to the encapsulation principle, we should make the `balance` field private and provide public methods or properties to access and modify it. Here is the improved version:

**BadExample Class with Encapsulation**
```cs
public class BadExample
{
    private decimal balance;

    public decimal Balance
    {
        get { return balance; }
        set { balance = value; }
    }
}
```

**Program.cs File with Encapsulation**
```cs
namespace Encapsulation;

public class Program
{
    public static void Main(string[] args)
    {
        BadExample badExampleBalance = new BadExample();
        badExampleBalance.Balance = 100; // Using property to set value
        Console.WriteLine(badExampleBalance.Balance); // Using property to get value
        Console.ReadLine();
    }
}
```

### Explanation of the Improved Version
- **Private Field**: The `balance` field is now private, which prevents direct access from outside the `BadExample` class.

```cs
private decimal balance;
```

- **Public Property**: A public property `Balance` is used to get and set the value of the `balance` field. This allows for validation or other logic to be added in the future if needed.

```cs
public decimal Balance
{
    get { return balance; }
    set { balance = value; }
}
```

By using proper encapsulation, the code is more robust, maintainable, and adheres to the principles of object-oriented programming.
</details>

## 📚 Resources
- [Microsoft C# Documentation](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [C# Object-Oriented Programming Guide](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/object-oriented-programming)

## 📄 License
This project is licensed under the MIT License - see the LICENSE file for details.
