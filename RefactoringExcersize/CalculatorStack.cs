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
            if (stack.Count > 1)
            {
                double first = stack.Pop();
                double second = stack.Pop();
                switch (input[0])
                {
                    case '+': stack.Push(first + second); return true;
                    case '*': stack.Push(first * second); return true;
                    case '-': stack.Push(second - first); return true;
                    case '/': stack.Push(second / first); return true;
                }
            }
            switch (input[0])
            {
                case 'c': stack.Clear(); return true;
                case 'q': return true;
            }
        }
        return false;
    }
}
