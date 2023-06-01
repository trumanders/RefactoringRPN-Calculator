namespace RefactoringExcersize;
public class CalculatorStack
{
    public Stack<double> stack = new Stack<double>();

    public string GetStackString()
    {
        return "[" + string.Join(", ", stack.ToArray()) + "]";
    }

    public bool HandleOperation(string input)
    {
        if (Char.IsDigit(input[0]))
        {
            stack.Push(Convert.ToDouble(input));
            return true;
        }

        else
        {
            switch (input[0])
            {
                case '+':
                    stack.Push(stack.Pop() + stack.Pop());
                    return true;

                case '*':
                    stack.Push(stack.Pop() * stack.Pop());
                    return true;

                case '-':
                    double subtract = stack.Pop();
                    stack.Push(stack.Pop() - subtract);
                    return true;

                case '/':
                    double divide = stack.Pop();
                    stack.Push(stack.Pop() / divide);
                    return true;

                case 'c':
                    stack.Clear();
                    return true;

                case 'q':
                    return true;
            }
        }
        return false;
    }
}
