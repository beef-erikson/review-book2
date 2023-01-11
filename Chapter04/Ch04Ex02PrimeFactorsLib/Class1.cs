namespace Ch04Ex02PrimeFactorsLib;
static class PrimeFactors
{
    static string PrimeFactors(int num)
    {
        string response = "";

        // Invalid number range
        if (num > 1000 || num < 2)
        {
            return "Number is not valid. Range is between 2 and 1000.";
        }

        for (int i = 2; i <= num; i++)
        {
            // find out if divisable evenly. If so, add to string
            if (i % num == 0)
            {
                response += $"{i} ";
            }
        }

        return response;
    }
}
