using RefactoringExcersize;

/* REFACTORING:
-   use Stack type (get rid of custom class DoubleStack)
-   rename 'command'
-   invalid input error handling with instructions
-   make calculator class
-   make input method
-   fix exception when entering digit first and then invalid symbol ex: "5+"
-   what is the purpose of entering 'q' ?
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
                else Console.WriteLine(calcStack.GetStackString());                

                string input = Console.ReadLine().Trim();
                if (input == "") input = " ";
                
                if (!calcStack.HandleOperation(input))                
                    Console.WriteLine("Illegal command, ignored");
            }
        }
    }
}
