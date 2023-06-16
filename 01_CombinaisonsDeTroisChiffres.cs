namespace Combinaison_de_3_chifres;

public static class Program
{
    private static List<string> CombinationsWithThreeDigits()
    {
        List<string> combinations = new();

        for(int i = 0; i <= 9; i++)
        {
            for(int j = (i + 1); j <= 9; j++)
            {
                for(int k = (j + 1); k <= 9; k++)
                {
                    combinations.Add(i.ToString() + j.ToString() + k.ToString());
                }
            }
        }
        return combinations;
    }

    public static void Main()
    {
        List<string> combinations = CombinationsWithThreeDigits();
        foreach(string combination in combinations)
        {
            Console.Write(combination + " ");
        }
    }
}