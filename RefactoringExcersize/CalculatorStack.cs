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
            if (!Double.TryParse(input, out double num)) return false;
            stack.Push(num);
            return true;
        }        
        else if (input.Length != 1) return false;
        else if (input[0] == 'c') { stack.Clear(); return true; }
        else if (stack.Count > 1 && performCalculation(input[0]))
            return true;                             
        return false;
    }

    private bool performCalculation(char operatr)
    {
        double firstNum = stack.Pop();
        double secondNum = stack.Pop();
        switch (operatr)
        {
            case '+': stack.Push(firstNum + secondNum); return true;
            case '*': stack.Push(firstNum * secondNum); return true;
            case '-': stack.Push(secondNum - firstNum); return true;
            case '/': stack.Push(secondNum / firstNum); return true;
        }
        return false;
    }   
}
