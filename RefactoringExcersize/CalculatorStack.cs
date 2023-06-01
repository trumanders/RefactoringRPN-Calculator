namespace RefactoringExcersize;
public class CalculatorStack
{
    public Stack<double> stack;

    public CalculatorStack()
    {
        stack = new Stack<double>();
    }

    //public int StackSize()
    //{
    //    return stack.Count();
    //}

    public void PrintStackString()
    {
        Console.WriteLine("[" + string.Join(", ", stack.ToArray()) + "]");
    }
}
