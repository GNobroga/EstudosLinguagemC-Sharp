string expression = "(1 + 2) * 3) - 4";

bool balenceada = EstaBalanceada(expression);

Console.WriteLine($"A expressão matemática {expression} é {(balenceada ? 
                   "esta balanceada" : "não esta balanceada")}.");

Console.ReadKey();

static bool EstaBalanceada(string expression)
{
    Stack<char> stack = new Stack<char>();

    foreach (char c in expression)
    {
        if (c == '(' || c == '{' || c == '[')
        {
            stack.Push(c);
        }
        else if (c == ')' || c == '}' || c == ']')
        {
            if (stack.Count == 0)
            {
                return false;
            }

            char lastParentheses = stack.Pop();

            if ((c == ')' && lastParentheses != '(') ||
               (c == '}' && lastParentheses != '{') ||
               (c == ']' && lastParentheses != '['))
            {
                return false;
            }
        }
    }

    return stack.Count == 0;
}
