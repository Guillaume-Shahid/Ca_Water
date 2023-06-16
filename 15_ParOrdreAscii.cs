namespace Par_ordre_Ascii;

internal static class Program
{
    private static bool CheckIfArgsExists(string[] args)
    {
        return args.Length > 1;
    }
    
    private static List<string> PutArgsInList(string[] args)
    {
        var argsList = new List<string>();
        for(var i = 1; i < (args.Length); i++)
        {
            argsList.Add(args[i]);
        }
        return argsList;
    }

    private static List<string> MySelectSort(List<string> listToSort)
    {
        var n = listToSort.Count;

        for (var i = 0; i < n - 1; i++)
        {
            var min = i;
            
            for(var j = i + 1; j < n; j++)
            {
                if (Convert.ToInt32(listToSort[j][0]) < Convert.ToInt32(listToSort[min][0]))
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
            var argsList = PutArgsInList(args);
            argsList = MySelectSort(argsList);
            
            Console.WriteLine(string.Join(" ", argsList));
        }
        else
        {
            Console.WriteLine("error");
        }
    }
}