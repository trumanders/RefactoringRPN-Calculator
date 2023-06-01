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
                if (calcStack.stack.Count == 0)
                {
                    Console.WriteLine("Commands: q c + - * / number");
                    Console.WriteLine("[]");
                    
                }
                else
                {
                    Console.WriteLine(calcStack.stack.Count);
                    calcStack.PrintStackString();
                }
                string input = Console.ReadLine().Trim();
                if (input == "") input = " ";
                char command = input[0];
                if (Char.IsDigit(command))
                {
                    double value = Convert.ToDouble(input);
                    calcStack.stack.Push(value);
                }
                else if (command == '+')
                {
                    calcStack.stack.Push(calcStack.stack.Pop() + calcStack.stack.Pop());
                }
                else if (command == '*')
                {
                    calcStack.stack.Push(calcStack.stack.Pop() * calcStack.stack.Pop());
                }
                else if (command == '-')
                {
                    double d = calcStack.stack.Pop();
                    calcStack.stack.Push(calcStack.stack.Pop() - d);
                }
                else if (command == '/')
                {
                    double d = calcStack.stack.Pop();
                    calcStack.stack.Push(calcStack.stack.Pop() / d);
                }
                else if (command == 'c')
                {
                    calcStack.stack.Clear();
                }
                else if (command == 'q')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Illegal command, ignored");
                }

            }
        }
    }
}
