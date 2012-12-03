using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

/// <summary>
/// Entry point to the rest of the program. 
/// </summary>


public class Client
{
    private int _result;
    private string _infix;

    public Client(string infix)
    {
        _infix = infix;

        AbstractFactory _factory = new BasicFactory();
        Stack<Command> _postfix = new Stack<Command>();
        new InfixToPostfix(_factory, ref _postfix, _infix); 
        Evaluator _evaluator = new Evaluator(_postfix);
        _result = _evaluator.calculate();
    }
    public int Result
    {
        get
        {
            return _result;
        }
    }

}