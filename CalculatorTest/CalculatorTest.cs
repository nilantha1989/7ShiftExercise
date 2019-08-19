using _7ShiftExercise.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using System.Text.RegularExpressions;

namespace CalculatorTest
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void TestSimpleScenario()
        {
            string pattern = @"-?\d+";
            string input = "1,2,3";
            var matches = Regex.Matches(input, pattern);

            StringBuilder positiveNumberList = new StringBuilder();
            for (int i = 0; i < matches.Count; i++)
            {
                int result = 0;

                if (!string.IsNullOrEmpty(matches[i].ToString()) && int.TryParse(matches[i].ToString(), out result) && result > 0 && result <= 1000)
                {

                    positiveNumberList.Append(result + ",");
                }
            }

            int expected = 6;


            CalculatorService calculatorService = new CalculatorService();
            int actual = calculatorService.Add(positiveNumberList.ToString().TrimEnd(','));

            Assert.AreEqual(expected, actual);
        }



        [TestMethod]
        public void TesVariousDelimetrs()
        {
            string pattern = @"-?\d+";
            string input = "//***\ndsada1fds***2***10”,3,4,2000,";
            var matches = Regex.Matches(input, pattern);

            StringBuilder positiveNumberList = new StringBuilder();
            for (int i = 0; i < matches.Count; i++)
            {
                int result = 0;

                if (!string.IsNullOrEmpty(matches[i].ToString()) && int.TryParse(matches[i].ToString(), out result) && result > 0 && result <= 1000)
                {

                    positiveNumberList.Append(result + ",");
                }
            }

            int expected = 20;


            CalculatorService calculatorService = new CalculatorService();
            int actual = calculatorService.Add(positiveNumberList.ToString().TrimEnd(','));

            Assert.AreEqual(expected, actual);
        }
    }
}
