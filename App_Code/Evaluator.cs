using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Evaluates the postfix stack and returns the integer result.
/// @in: Stack<command>
/// @out: int
/// </summary>
public class Evaluator
{
    Stack<Command> _postfix = new Stack<Command>();
    public Evaluator(Stack<Command> postfix)
    {
        _postfix = new Stack<Command>(postfix);
    }

    public int calculate()
    {
        Stack<int> _result = new Stack<int>();
        foreach (Command _cmd in _postfix)
        {
            _cmd.Execute(_result);
        }
        return _result.Pop();
    }
}