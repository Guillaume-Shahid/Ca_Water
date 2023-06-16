namespace Tri_pas_selection;

internal static class Program
{
    private static bool CheckIfArgsExists(IReadOnlyCollection<string> args)
    {
        return args.Count > 2;
    }
    
    private static List<int> PutArgsInList(IReadOnlyList<string> args)
    {
        var argsList = new List<int>();
        for(var i = 1; i < (args.Count); i++)
        {
            argsList.Add(int.Parse(args[i]));
        }
        return argsList;
    }

    private static List<int> MySelectSort(List<int> listToSort)
    {
        var n = listToSort.Count;

        for (var i = 0; i < n - 1; i++)
        {
            var min = i;
            
            for(var j = i + 1; j < n; j++)
            {
                if (listToSort[j] < listToSort[min])
                {
                    min = j;
                }
            }
            if(min != i)
            {
                (listToSort[i], listToSort[min]) = (listToSort[min], listToSort[i]);
            }
        }
        return listToSort;
    }

    public static void Main(string[] args)
    {
        if (CheckIfArgsExists(args))
        {
            try
            {
                var argsList = PutArgsInList(args);
                argsList = MySelectSort(argsList);

                Console.WriteLine(string.Join(" ", argsList));
            }
            catch
            {
                Console.WriteLine("error");
            }
        }
        else
        {
            Console.WriteLine("error");
        }
    }
}