string? password;
string[] names = { "Soup", "Boot", "Foot" };

int x = 0;
while (x < 10)
{
    WriteLine(x);
    x++;
}

for (int y = 1; y <= 10; y++)
{
    WriteLine(y);
}

foreach (string name in names)
{
    WriteLine($"{name} has {name.Length} characters.");
}

do
{
    if (x >= 0)
    {
        Write("Enter your password: ");
        password = ReadLine();
        x--;
    }
    else
    {
        WriteLine("Too many failed attempts!");
        break;
    }
}
while (password != "Pa$$w0rd");
WriteLine("Correct!");
