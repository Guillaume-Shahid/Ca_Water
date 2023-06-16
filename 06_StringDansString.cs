public class String_dans_string
{
    private static bool CheckIfArgsExists(string[] args, int maximumArgs)
    {
        return args.Length >= (maximumArgs + 1);
    }

    private static bool StringReallyContainsString(string stringToCheck, string stringToFind, int startingIndex)
    {
        for(int j = 0; j < stringToFind.Length; j++)
        {
            if ((stringToCheck[startingIndex + j] != stringToFind[j]))
            {
                return false;
            }
        }
        return true;
    }
    
    private static bool StringInString (string stringToCheck, string stringToFind)
    {
        try
        {
            for(int i = 0; i < stringToCheck.Length; i++)
            {
                if(stringToCheck[i] == stringToFind[0] && StringReallyContainsString(stringToCheck, stringToFind, i))
                {
                    return true;
                }
            }
            return false;
        }
        catch
        {
            return false;
        }
    }

    
    public static void Main(string[] args)
    {
        const int MAXIMUM_ARGS = 2;

        if (CheckIfArgsExists(args, MAXIMUM_ARGS))
        {
            Console.WriteLine(StringInString(args[1], args[2]));
        }
        else
        {
            Console.WriteLine("error");
        }
    }
}