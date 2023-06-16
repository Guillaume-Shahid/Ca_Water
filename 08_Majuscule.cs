namespace Majuscule
{
    internal static class Program
    {
        private static bool CheckIfArgsExists(string[] args, int maximumArgs)
        {
            return args.Length == (maximumArgs + 1);
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

        private static List<string> SplitString(string stringToSplit)
        {
            List<string> stringList = new();
            const char SEPARATOR = ' ';

            string stringToAdd = "";

            foreach (var word in stringToSplit)
            {
                if(word == SEPARATOR)
                {
                    stringList.Add(stringToAdd);
                    stringToAdd = "";
                }
                else
                {
                    stringToAdd += word;
                }
            }
            stringList.Add(stringToAdd);
            return stringList;
        }

        private static List<string> PutFirstCharOfEachWordInUpperCase(List<string> stringsToChanges)
        {
            List<string> finalString = new();

            foreach (var word in stringsToChanges)
            {
                string wordWithUpperCase = "";

                for(int i = 0; i < word.Length; i++)
                {
                    if(i == 0)
                    {
                        wordWithUpperCase += char.ToUpper(word[i]);
                    }
                    else
                    {
                        wordWithUpperCase += char.ToLower(word[i]);
                    }
                }
                finalString.Add(wordWithUpperCase);
            }
            return finalString;
        }

        private static string DisplayFinalString(List<string> stringsToDisplays)
        {
            return String.Join(" ", stringsToDisplays);
        }

        public static void Main(string[] args)
        {
            const int MAXIMUM_ARGS = 1;

            if(CheckIfArgsExists(args, MAXIMUM_ARGS) && !CheckIfArgIsOnlyNumber(args[1]))
            {
                List<string> stringsToChanges = SplitString(args[1]);
                stringsToChanges = PutFirstCharOfEachWordInUpperCase(stringsToChanges);
                Console.WriteLine(DisplayFinalString(stringsToChanges));
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}