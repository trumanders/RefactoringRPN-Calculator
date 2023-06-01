namespace RefactoringExcersize;
public class CalculatorStack
{
    public Stack<double> stack = new Stack<double>();

    public string GetStackString()
    {
        return "[" + string.Join(", ", stack.ToArray()) + "]";
    }
}
