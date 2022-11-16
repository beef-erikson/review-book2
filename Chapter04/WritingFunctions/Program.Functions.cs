partial class Program
{
    static void TimesTable(byte number, byte size = 12)
    {
        WriteLine($"This is the {number} times table with {size} rows:");
        for (int row = 1; row <= size; row++)
        {
            WriteLine($"{row} x {number} = {row * number}");
        }
        WriteLine();
    }

    static decimal CalculateTax(decimal amount, string twoLetterRegionCode)
    {
        decimal rate = twoLetterRegionCode switch
        {
            "CH" => 0.08M,
            "DK" => 0.25M,
            "NO" => 0.25M,
            "GB" => 0.2M,
            "FR" => 0.2M,
            "HU" => 0.27M,
            "OR" => 0.0M,
            "AK" => 0.0M,
            "MT" => 0.0M,
            "ND" => 0.05M,
            "WI" => 0.05M,
            "ME" => 0.05M,
            "VA" => 0.05M,
            "CA" => 0.0825M,
            _ => 0.06M
        };
        return amount * rate;
    }

    static string CardinalToOrdinal(int number)
    {
        int lastTwoDigits = number % 100;

        switch (lastTwoDigits)
        {
            case 11:
            case 12:
            case 13:
                return $"{number:N0}th";
            default:
                int lastDigit = number % 10;

                string suffix = lastDigit switch
                {
                    1 => "st",
                    2 => "nd",
                    3 => "rd",
                    _ => "th"
                };

                return $"{number:N0}{suffix}";
        };
    }

    static void RunCardinalToOrdinal()
    {
        for (int number = 1; number <= 1500; number++)
        {
            Write($"{CardinalToOrdinal(number)} ");
        }
        WriteLine();
    }
}