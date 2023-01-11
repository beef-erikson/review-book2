namespace Ch04Ex02PrimeFactorsLib;
static class PrimeFactors
{
    string response = "";

    static string PrimeFactors(int num)
    {
        // Invalid number range
        if (num > 1000 || num < 2)
        {
            return "Number is not valid. Range is between 2 and 1000.";
        }

        for (int i = 2; i <= num; i++)
        {
            // find out if divisable evenly. If so, add to string and, if not evenly divisable, recurse
            if (i % num == 0)
            {
                response += $"{i} ";
                if (i / num != 1)
                {
                    PrimeFactors(i / num);
                }
            }

            return response;
        }
    }
}