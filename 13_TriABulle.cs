namespace Tri_a_bulle;

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
    
    private static IEnumerable<int> MyBubbleSort(IList<int> listToSort)
    {
        for (var i = (listToSort.Count) ; i >= 1; i--)
        {
            var isSorted = true;

            for (var j = 0; j < i - 1; j++)
            {
                if(listToSort[j + 1] < listToSort[j])
                {
                    (listToSort[j], listToSort[j + 1]) = (listToSort[j + 1], listToSort[j]);
                    isSorted = false;
                }
            }

            if (isSorted)
            {
                return listToSort;
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
                var sortedList = MyBubbleSort(argsList);

                Console.WriteLine(string.Join(" ", sortedList));
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