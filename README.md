# FirstBankOfSuncoast

## Assignment

The goal of this assignment was to create a console app that allows a user to manage savings and checking banking transactions. A user can/will make a series of transactions as well.

<details>
<summary>Example</summary>
<br/> 
User transactions: 
<br/><br/>
A user deposits $10 to their savings 
<br/> 
Then withdraws $8 from their savings 
<br/>
Then deposits $25 to their checking 
<br/><br/>
The user has three transactions to consider 
<br/><br/>
In this case, the user's savings balance is $2 and their checking balance is $25
</details>

The transactions have been **saved** in a file, using a `CSV` format to record the data.

```csharp
var existingPassword = "";

StringBuilder securePassword = new StringBuilder();
while (true)
{
    var keyPressed = Console.ReadKey(true);

    if (keyPressed.Key == ConsoleKey.Enter)
    {
        break;
    }
    if (keyPressed.Key == ConsoleKey.Backspace)
    {
        if (securePassword.Length > 0)
        {
            Console.Write("\b \b");
            securePassword.Length--;
        }
        continue;
    }

    Console.Write("*");
    securePassword.Append(keyPressed.KeyChar);


}
existingPassword += securePassword.ToString();

// Testing to see if password is being typed.
// Console.WriteLine($"\n{existingPassword}");
```

Above is a code snippet from my project that I made to hide a user's password as they are typing it.
