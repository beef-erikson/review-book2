try
{
    Write("Enter two numbers between 0 and 255. First number: ");
    int num1 = int.Parse(ReadLine()!);
    Write("Enter second number: ");
    int num2 = int.Parse(ReadLine()!);

    WriteLine($"{num1} divided by {num2} is {num1 / num2}.");
}
catch (System.FormatException e)
{
    WriteLine(e.Message);
}
catch (System.Exception e)
{
    WriteLine(e);
    throw;
}