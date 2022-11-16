partial class Program
{
    /// <summary>
    /// Writes the times tables based on the number and size.
    /// E.g. 5, 5 would do 5x1, 5x2 ... 5x5
    /// </summary>
    /// <param name="number">Number to multiply.</param>
    /// <param name="size">Size of times table.</param>
    static void TimesTable(byte number, byte size = 12)
    {
        WriteLine($"This is the {number} times table with {size} rows:");
        for (int row = 1; row <= size; row++)
        {
            WriteLine($"{row} x {number} = {row * number}");
        }
        WriteLine();
    }

    /// <summary>
    /// Calculates tax based on amount and region.
    /// </summary>
    /// <param name="amount">Decimal amount of money i.e 4.66.</param>
    /// <param name="twoLetterRegionCode">Two-letter region code, i.e. PA.</param>
    /// <returns></returns>
    static decimal CalculateTax(decimal amount, string twoLetterRegionCode)
    {
        decimal rate = twoLetterRegionCode switch
        {
            "CH" => 0.08M,
            "DK" or "NO" => 0.25M,
            "GB" or "FR" => 0.2M,
            "HU" => 0.27M,
            "OR" or "AK" or "MT" => 0.0M,
            "ND" or "WI" or "ME" or "VA" => 0.05M,
            "CA" => 0.0825M,
            _ => 0.06M
        };
        return amount * rate;
    }

    /// <summary>
    /// Pass a 32-bit integer and it will be converted into its ordinal equivalent.
    /// </summary>
    /// <param name="number">Number as a cardinal value e.g. 1, 2, 3, and so on.</param>
    /// <returns>Number as an ordinal value e.g. 1st, 2nd, 3rd, and so on.</returns>
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

    /// <summary>
    /// Runs CardinalToOrdinal() 1500 times.
    /// </summary>
    static void RunCardinalToOrdinal()
    {
        for (int number = 1; number <= 1500; number++)
        {
            Write($"{CardinalToOrdinal(number)} ");
        }
        WriteLine();
    }

    /// <summary>
    /// Returns a factorial for non-negative numbers recursively.
    /// </summary>
    /// <param name="number">Number to get the factorial of.</param>
    /// <returns>Integer of factorial.</returns>
    static int Factorial(int number)
    {
        if (number < 0)
        {
            throw new ArgumentException(
                message: $"The factorial function is defined for non-negative integers only. Input: {number}",
                paramName: nameof(number));
        }
        else if (number == 0)
        {
            return 1;
        }
        else
        {
            checked
            {
                return number * Factorial(number - 1);
            }
        }
    }

    /// <summary>
    /// Runs Factorial for the first 15 numbers.
    /// </summary>
    static void RunFactorial()
    {
        for (int i = -2; i <= 15; i++)
        {
            try
            {
                WriteLine($"{i}! = {Factorial(i):N0}");
            }
            catch (OverflowException)
            {
                WriteLine($"{i}! is too big for a 32-bit integer.");
            }
            catch (Exception ex)
            {
                WriteLine($"{i}! throws {ex.GetType()}: {ex.Message}");
            }
        }
    }

    /// <summary>
    /// The fibonacci sequence using imperative style.
    /// </summary>
    /// <param name="term">Integer of terms to run.</param>
    /// <returns>Fibonacci of the supplied term.</returns>
    static int FibImperative(int term)
    {
        if (term == 1)
        {
            return 0;
        }
        else if (term == 2)
        {
            return 1;
        }
        else
        {
            return FibImperative(term - 1) + FibImperative(term - 2);
        }
    }

    /// <summary>
    /// Runs FibImperative for 30 numbers.
    /// </summary>
    static void RunFibImperative()
    {
        for (int i = 1; i <= 30; i++)
        {
            WriteLine("The {0} term of the Fibonacci sequence is {1:N0}.",
                arg0: CardinalToOrdinal(i),
                arg1: FibImperative(term: i));
        }
    }

    /// <summary>
    /// The fibonacci sequence using declarative style
    /// </summary>
    /// <param name="term">Integer of term to run</param>
    /// <returns>Fibonacci of the supplied term.</returns>
    static int FibFunctional(int term) =>
        term switch
        {
            1 => 0,
            2 => 1,
            _ => FibFunctional(term - 1) + FibFunctional(term - 2)
        };

    /// <summary>
    /// Runs FibFunctional for 30 numbers.
    /// </summary>
    static void RunFibFunctional()
    {
        for (int i = 1; i <= 30; i++)
        {
            WriteLine("The {0} term of the Fibonacci sequence is {1:N0}.",
                arg0: CardinalToOrdinal(i),
                arg1: FibFunctional(term: i));
        }
    }
}