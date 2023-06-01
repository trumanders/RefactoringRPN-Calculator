namespace RefactoringExcersize;
public class CalculatorStack
{
    public Stack<double> stack = new Stack<double>();

    public string GetStackString()
    {
        return "[" + string.Join(", ", stack.ToArray()) + "]";
    }

    public HandleOperation(char input)
    {
        if (stack.Count == 0)
        {
            Console.WriteLine("Commands: q c + - * / number");
            Console.WriteLine("[]");
        }
        else
        {
            Console.WriteLine(GetStackString());
        }

        switch (input)
        {
            case '+':
                stack.Push(stack.Pop() + stack.Pop());
                break;
            case '*':
                stack.Push(stack.Pop() * stack.Pop());

                break;
            case '-':
                double d = stack.Pop();
                stack.Push(stack.Pop() - d);
                break;
            case '/':
                double d = stack.Pop();
                stack.Push(stack.Pop() / d);
                break;
            case 'c':
                stack.Clear();
                break;
            case 'q':
                break;

        }



        if (Char.IsDigit(command))
        {
            double value = Convert.ToDouble(input);
            stack.Push(value);
        }
        else if (command == '+')
        {
            
        }
        else if (command == '*')
        {
            
        }
        else if (command == '-')
        {
            
        }
        else if (command == '/')
        {
            
        }
        else if (command == 'c')
        {
            
        }
        else if (command == 'q')
        {
            break;
        }
    }
}
