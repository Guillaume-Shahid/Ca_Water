internal class Program
{
    private static bool CheckIfArgsExists(string[] args, int maximumArgs)
    {
        return args.Length >= (maximumArgs + 1); 
    }
    
        private static bool CheckIfArgIsOnlyNumber(string arg)
        {
            try
            {
                return double.TryParse(arg, out _);
            }
            catch
            {
                return false;
            }
        }
    
    private static bool IsAsciiIsUpperCase(int ascii)
    {
        if(ascii <= 90 && ascii >= 65)
        {
            return true;
        }
        return false;
    }
    
    private static bool IsAsciiIsLowerCase(int ascii)
    {
        if(ascii <= 122 && ascii >= 97)
        {
            return true;
        }
        return false;
    }
    
    private static bool IsAsciiIsSpecialChar(int ascii)
    {
        if(ascii <= 64 || (ascii >= 91 && ascii <= 96) || ascii >= 123)
        {
            return true;
        }
        return false;
    }

    private static string OneOnTwoToUpper (string stringToChange)
    {
        try
        {
            string stringToReturn = "";
            int numberOfSpecialChar = 0;

            for(int i = 0; i < stringToChange.Length; i++)
            {
                int stringConvertInDecimal = Convert.ToInt32(stringToChange[i]);

                if(IsAsciiIsSpecialChar(stringConvertInDecimal))
                {
                    numberOfSpecialChar++;
                }
                
                if(i == 0 && IsAsciiIsLowerCase(stringConvertInDecimal) || 
                   ((i + numberOfSpecialChar) % 2 == 0 && IsAsciiIsLowerCase(stringConvertInDecimal)))
                {
                    stringToReturn += Convert.ToChar(stringConvertInDecimal - 32).ToString();
                    
                }
                else if(i != 0 && 
                        (i + numberOfSpecialChar) % 2 != 0 && 
                         IsAsciiIsUpperCase(stringConvertInDecimal))
                {
                    stringToReturn += Convert.ToChar(stringConvertInDecimal + 32).ToString();
                }
                else
                {
                    stringToReturn += stringToChange[i].ToString();
                }
            }
            return stringToReturn;
        }
        catch
        {
            return "error";
        }
        
    }

    private static void Main(string[] args)
    {
        const int MAXIMUM_ARGS = 1;

        if (CheckIfArgsExists(args, MAXIMUM_ARGS) && !CheckIfArgIsOnlyNumber(args[1]))
        {
            Console.WriteLine(OneOnTwoToUpper(args[1]));
        }
        else
        {
            Console.WriteLine("error");
        }
    }
}