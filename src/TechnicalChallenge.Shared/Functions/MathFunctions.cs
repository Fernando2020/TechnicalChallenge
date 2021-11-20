namespace TechnicalChallenge.Shared.Functions
{
    public static class MathFunctions
    {
        public static bool IsDivider(long divider, long dividend)
        {
            if (divider % dividend == 0)
            {
                return true;
            }

            return false;
        }

        public static bool IsPrimeNumber(long number)
        {
            var count = 0;
            for (var i = 1; i <= number; i++)
            {
                if (IsDivider(number, i))
                {
                    count++;
                }
            }

            if (count == 2)
            {
                return true;
            }

            return false;
        }
    }
}
