namespace Combinaisons_de_2_nombres
{
    internal static class CombinaisonsDe2Nombres
    {
        private static List<string> ListOfNumberWithTwoDigits()
        {
            List<string> numbers = new();
            
            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j <= 9; j++)
                {
                    numbers.Add(i.ToString() + j.ToString());
                }
            }
            return numbers;
        }

        private static IEnumerable<string> CombinationWithTwoNumbers()
        {
            List<string> combinations = new();
            var numbers = ListOfNumberWithTwoDigits();

            foreach (string number in numbers)
            {
                foreach (string number2 in numbers)
                {
                    if (int.Parse(number) < int.Parse(number2))
                    {
                        combinations.Add($"{number} {number2}");
                    }
                }
            }
            return combinations;
        }

        public static void Main()
        {
            var combinations = CombinationWithTwoNumbers();

            Console.Write(string.Join(", ", combinations));
        }
    }
}