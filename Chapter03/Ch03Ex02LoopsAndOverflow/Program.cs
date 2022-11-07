int max = 500;


for (byte i = 0; i < max; i++)
{
    WriteLine(i);
    if (max > byte.MaxValue)
    {
        WriteLine("This is going to overflow.");
    }
}