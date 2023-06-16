namespace Chiffres_only
{
    internal static class Program
    {
        private static bool CheckIfArgsExists(string[] args, int maximumArgs)
        {
            return args.Length == (maximumArgs + 1);
        }

        private static List<char> GetNumbers()
        {
            List<char> numbers = new();
            
            for (var i = 0; i < 10; i++)
            {
                numbers.Add(i.ToString()[0]);
            }
            return numbers;
        }

        private static bool CheckIfArgIsOnlyNumber(string arg)
        {
            var numbers = GetNumbers();

            foreach (var character in arg)
            {
                if (!numbers.Contains(character))
                {
                    return false;
                }
            }
            return true;
        }
        public static void Main(string[] args)
        {
            const int MAXIMUM_ARGS = 1;

            if (CheckIfArgsExists(args, MAXIMUM_ARGS))
            {
                Console.WriteLine(CheckIfArgIsOnlyNumber(args[1]));
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}