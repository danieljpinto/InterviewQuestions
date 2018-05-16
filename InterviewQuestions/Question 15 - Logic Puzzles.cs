using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    /// <summary>
    /// Without creating another variable, write code to swap around the values of firstNumber and secondNumber
    /// </summary>
    public class Question15
    {
        public void SwitchNumbers(int firstNumber, int secondNumber)
        {
            //3, 6

            secondNumber = secondNumber + firstNumber; // 3, 9

            firstNumber = firstNumber - secondNumber; // -6, 9

            secondNumber = secondNumber - firstNumber; // -6, 3

            firstNumber = 0 - firstNumber; // 6, 3
        }
    }
}
