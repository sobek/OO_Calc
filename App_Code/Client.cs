using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

/// <summary>
/// Summary description for Client
/// </summary>


public class Client
{
    private int _result;
    private string _infix;
    private string _replacement;
    private string _pattern;

    public Client(string infix)
    {
        _pattern = "\\s+";
        _replacement = "";
        Regex rgx = new Regex(_pattern);
        _infix = rgx.Replace(infix, _replacement);

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