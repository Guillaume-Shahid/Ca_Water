namespace Namespace
{
    internal static class Program
    {
        private static bool CheckIfArgsExists(string[] args, int maximumArgs)
        {
            return args.Length == (maximumArgs + 1);
        }

        private static int CountDivider(int numberToDivide)
        {
            int countDivider = 0;
            
            for (int i = 2; i < numberToDivide; i++)
            {
                if ((numberToDivide % i) == 0)
                {
                    countDivider++;
                }
            }

            return countDivider;
        }

        private static int FindNextPrimeNumber(int number)
        {
            while (true)
            {
                number++;
                
                if (number <= 2)
                {
                    return 2;
                }
                else
                {
                    if (CountDivider(number) == 0)
                    {
                        return number;
                    }
                }
            }
        }

        public static void Main(string[] args)
        {
            const int MAXIMUM_ARGS = 1;

            if (CheckIfArgsExists(args, MAXIMUM_ARGS))
            {
                try
                {
                    int numberToFindNextPrime = Int32.Parse(args[1]);

                    if (numberToFindNextPrime >= 0)
                    {
                        Console.WriteLine(FindNextPrimeNumber(numberToFindNextPrime));
                    }
                    else
                    {
                        Console.WriteLine(-1);
                    }
                }
                catch
                {
                    Console.WriteLine(-1);
                }
            }
            else
            {
                Console.WriteLine(-1);
            }
        }
    }
}