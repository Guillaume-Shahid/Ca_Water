using System.Collections.Generic;
internal partial class Program
{
    private static bool CheckIfArgsExists(string[] args)
    {
        return args.Length > 2;
    }

    private static List<int> PutArgsInList(string[] args)
    {
        List<int> argsList = new List<int>();
        for(int i = 1; i < (args.Length); i++)
        {
            argsList.Add(int.Parse(args[i]));
        }
        return argsList;
    }

    private static int IsNumberBelowZero(int number)
    {
        if(number < 0)
        {
            return -number;
        }
        else
        {
            return number;
        }
    }

    private static int IsSubstrationIsBelowPreviousResult(int substraction, int result)
    {
        if(substraction < result)
        {
            return substraction;
        }
        else
        {
            return result;
        }
    }

    private static int FindAbsoluteMinimum(List<int> argsList)
    {
        int result = 0;

        for(int i = 0; i < argsList.Count; i++)
        {
            int iValue = argsList[i];

            for(int j = i + 1; j < argsList.Count; j++)
            {
                int jValue = argsList[j];
                int substraction = IsNumberBelowZero(iValue - jValue);

                if (j == 1)
                {
                    result = substraction;
                }
                else
                {
                    result = IsSubstrationIsBelowPreviousResult(substraction, result);
                }
            }
        }
        return result;
    }

    private static void Main(string[] args)
    {
        if(CheckIfArgsExists(args))
        {
            try
            {
                List<int> argsList = PutArgsInList(args);
                
                Console.WriteLine(FindAbsoluteMinimum(argsList));
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