using System.Collections.Generic;
internal partial class Program
{
    private static bool CheckIfArgsExists(string[] args, int maximumArgs)
    {
        return args.Length == (maximumArgs + 1);
    }
    
    private static List<int> NumberBetween(int number1, int number2)
    {
        List<int> numbers = new List<int>();

        if(number1 > number2)
        {
            (number1, number2) = (number2, number1); 
        }
        
        for(int i = number1; i < number2; i++)
        {
            numbers.Add(i);
        }
        return numbers;
    }

    private static void Main(string[] args)
    {
        const int MAXIMUM_ARGS = 2; 

        if(CheckIfArgsExists(args, MAXIMUM_ARGS))
        {
            try
            {
                
                int number1 = Int32.Parse(args[1]);
                int number2 = Int32.Parse(args[2]);

                var numbers = NumberBetween(number1, number2);
                Console.WriteLine(string.Join(" ", numbers));
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