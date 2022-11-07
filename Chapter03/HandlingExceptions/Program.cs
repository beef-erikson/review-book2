﻿WriteLine("Before parsing");
Write("What is your age? ");
string? input = ReadLine();

try
{
    int age = int.Parse(input!); // ! is null-forgiving operator
    WriteLine($"You are {age} years old.");
}
catch (FormatException)
{
    WriteLine("The age you entered is not in a valid number format.");
}
catch (Exception ex)
{
    WriteLine($"{ex.GetType()} says {ex.Message}");
}
WriteLine("After parsing");

Write("Enter an amount: ");
string amount = ReadLine()!;

if (string.IsNullOrEmpty(amount)) return;

try
{
    decimal amountValue = decimal.Parse(amount);
    WriteLine($"Amount formatted as currency: {amountValue:C}");
}
catch (FormatException) when (amount.Contains("$"))
{
    WriteLine("Amounts cannot use the dollar sign!");
}
catch (Exception)
{
    WriteLine("Amounts may only contain digits!");
}