using _7ShiftExercise.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _7ShiftExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter input string: ");

            string input = Console.ReadLine();
            if (input.Length == 0)
            {
                Console.WriteLine("Sum : " + input.Length.ToString());
                Console.Read();
            }

            List<int> negativeInt = new List<int>();
            string pattern = @"-?\d+";
            var matches = Regex.Matches(input, pattern);

            StringBuilder negativeNumberList = new StringBuilder("Negative numbers in the string:");
            StringBuilder positiveNumberList = new StringBuilder();
            for (int i = 0; i < matches.Count; i++)
            {
                int result = 0;

                if (!string.IsNullOrEmpty(matches[i].ToString()) && int.TryParse(matches[i].ToString(), out result) && result > 0 && result <= 1000)
                {

                    positiveNumberList.Append(result + ",");
                }
                if (result < 0)
                {
                    negativeNumberList.Append(result.ToString() + ",");
                    negativeInt.Add(result);
                }


            }

            if (negativeInt.Count > 0)
            {
                Console.WriteLine(new Exception("Negatives not allowed."));
                Console.WriteLine(negativeNumberList.ToString().TrimEnd(','));
                Console.Read();
            }
            else if (positiveNumberList.Length > 0)
            {
                CalculatorService calculatorService = new CalculatorService();
                Console.WriteLine("Sum: " + calculatorService.Add(positiveNumberList.ToString().TrimEnd(',')));
                Console.Read();
            }
            else
            {
                Console.WriteLine("Not found any number");
                Console.Read();
            }
        }
    }
}
