for (int i = 1; i <= 100; i++)
{
    // fizzbuzz
    if (i % 3 == 0 && i % 5 == 0)
    {
        Write("Fizzbuzz ");
        continue;
    }
    // fizz
    else if (i % 3 == 0)
    {
        Write("Fizz ");
        continue;
    }
    // buzz
    else if (i % 5 == 0)
    {
        Write("Buzz ");
        continue;
    }
    else
    {
        Write($"{i} ");
    }
}