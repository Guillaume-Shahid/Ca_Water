using System.Collections.Generic;
internal partial class Program
{
    private static bool CheckIfArgsExists(string[] args)
    {
        return args.Length > 1;
    }

    private static List<string> PutArgsInList(string[] args)
    {
        List<string> argsList = new();
        
        for(int i = 1; i < (args.Length - 1); i++)
        {
            argsList.Add(args[i]);
        }
        return argsList;
    }

    private static int FindIndex(List<string> argsList, string argToFind)
    {
        for(int i = 0; i < argsList.Count; i++)
        {
            if(argsList[i] == argToFind)
            {
                return i;
            }
        }
        return -1;
    }

    private static void Main(string[] args)
    {
        if(CheckIfArgsExists(args))
        {
            List<string> argsList = PutArgsInList(args);
            string argToFind = args[args.Length - 1];
            
            Console.WriteLine(FindIndex(argsList, argToFind));
        }  
        else
        {
            Console.WriteLine("error");
        }
    }
}