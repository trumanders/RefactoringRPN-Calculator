using RefactoringExcersize;
using System;
using System.Text;


/* REFACTORING:
-   use Stack type (get rid of custom class DoubleStack)
-   rename 'command'
-   invalid input error handling with instructions
-   make calculator class
-   make input method
-   
*/


namespace CalculatorRPN
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorStack calcStack = new CalculatorStack();
            while (true)
            {

                string input = Console.ReadLine().Trim();
                if (input == "") input = " ";
                calcStack.HandleOperation(input[0]);

                else
                {
                    Console.WriteLine("Illegal command, ignored");
                }

            }
        }
    }
}
