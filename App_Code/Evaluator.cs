using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// @in: Stack<command>
/// @out: int
/// </summary>
public class Evaluator
{
    List<Command> _postfix = new List<Command>();
    public Evaluator(Stack<Command> postfix)
    {
        _postfix = new List<Command>(postfix.Reverse());
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