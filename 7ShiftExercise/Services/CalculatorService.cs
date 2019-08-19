using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7ShiftExercise.Services
{
    public class CalculatorService
    {
        public int Add(string input)
        {

            //string input = "“//***\ndsada1fds***2***10”,3,4,2000,-3,--4";

            int resultVal = 0;

            string[] numberList = input.Split(',');

            for (int i = 0; i < numberList.Length; i++)
            {

                resultVal = resultVal + Convert.ToInt32(numberList[i]);

            }


            return resultVal;
        }
    }
}
