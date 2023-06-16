namespace Parametres_a_l_envers;

internal static class Program
{
    private static List<string> ReverseArgs(IReadOnlyList<string> args)
    {
        List<string> result = new();

        for (var i = args.Count - 1; i > 0; i--)
        {
            result.Add(args[i]);
        }
        return result;
    }

    public static void Main(string[] args)
    {
        var result = ReverseArgs(args);

        if (args.Length > 1)
        {
            try
            {
                foreach (var arg in result)
                {
                    Console.WriteLine(arg);
                }
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }
        else
        {
            Console.WriteLine("Error");
        }
    }
}