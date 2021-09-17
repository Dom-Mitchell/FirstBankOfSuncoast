# FirstBankOfSuncoast

## Assignment



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
