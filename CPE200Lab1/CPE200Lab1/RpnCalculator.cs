using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;  //For use stack

namespace CPE200Lab1
{
    class RpnCalculator : CalculatorEngine
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

       public void rpnCalculate(String lblDisplay)
       {
          
       }
    }

   // public override calculate(string operate,string firstOperand, string )

   
}
