namespace Suite_de_Fibonacci
{
    internal static class Program
    {
        private static bool CheckIfArgsExists(string[] args, int maximumArgs)
        {
            return args.Length == (maximumArgs + 1);
        }

        private static int FibonacciSequenceUpToTheNthNumber(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return FibonacciSequenceUpToTheNthNumber(n - 1) + 
                       FibonacciSequenceUpToTheNthNumber(n - 2);
            }
        }

        public static void Main(string[] args)
        {
            const int MAXIMUM_ARGS = 1;
            
            try
            {
                if (CheckIfArgsExists(args, MAXIMUM_ARGS) && int.Parse(args[1]) >= 0)
                {
                    int argValue = int.Parse(args[1]);

                    Console.WriteLine(FibonacciSequenceUpToTheNthNumber(argValue));
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
    }
}