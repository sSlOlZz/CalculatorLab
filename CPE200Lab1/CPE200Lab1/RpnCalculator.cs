using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;  //For use stack


namespace CPE200Lab1
{
    class RpnCalculatorEngine : CalculatorEngine
    {

        
        public void testStackMethod()
        {
            Stack testStack = new Stack();
            testStack.Push("1");
            testStack.Push("3");
            testStack.Push("hello");
            Console.Out.WriteLine(testStack.Pop());
            Console.Out.WriteLine(testStack.Pop());
        }

       public string RpnProcess(string stringInput)
       {
            string[] parts = stringInput.Split(' ');
            string result = null;
            Stack rpnStack = new Stack();
            string input = null;

            for(int i=0;i<parts.Length;i++)
            {
                input = parts[i];
                if (isNumber(input))
                {
                    rpnStack.Push(input);
                }
                else if (isOperator(input) && input != "1/x" && input != "√" && input != "%")
                {
                    string rpnOperate = input;
                    string firstRpnOperand = rpnStack.Pop().ToString();
                    string secondRpnOperand = rpnStack.Pop().ToString();
                    result = calculate(rpnOperate, secondRpnOperand, firstRpnOperand);
                    rpnStack.Push(result);
                }
                else if (input == "1/x" || input == "√")
                {
                    string rpnOperate = input;
                    string firstRpnOperand = rpnStack.Pop().ToString();
                    result = unaryCalculate(rpnOperate, firstRpnOperand);
                    rpnStack.Push(result);
                }

                if (input == "%")
                {

                    string firstRpnOperand = rpnStack.Pop().ToString();
                    string secondRpnOperand = rpnStack.Pop().ToString();
                    double get = (Convert.ToDouble(firstRpnOperand) * Convert.ToDouble(secondRpnOperand)) / 100;
                    rpnStack.Push(firstRpnOperand);
                    rpnStack.Push(get);

                }
        }
            return result;
        }

           
          
    }

   // public override calculate(string operate,string firstOperand, string )

   
}
