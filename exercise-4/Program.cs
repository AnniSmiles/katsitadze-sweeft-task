//exercise 4
bool longestValidParentheses(String s)
{
    int answer = 0;
    Stack<int> stack = new Stack<int>();
    stack.Push(-1);
    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] == '(')
        {
            stack.Push(i);
        }
        else
        {
            stack.Pop();
            if (stack.Count == 0)
                stack.Push(i);
            else
                answer = Math.Max(answer, i - stack.Peek());
        }
    }
    if (answer != 0 && s.Length % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}
Console.WriteLine(longestValidParentheses("(()())"));