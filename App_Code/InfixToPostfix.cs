using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;

/// <summary>
/// @in: BasicFactory
/// @in: Stack<Command>
/// @in: string
/// Creates postfix stack from infix input.
///</summary>
///
public class InfixToPostfix
{
    private string[] _infix;
    private Command _cmd;
    private Stack<Command> _temp_stack = new Stack<Command>();
    int temp;

    delegate Command MethodChooser();

    public InfixToPostfix(AbstractFactory factory, Stack<Command> postfix, string infix)
    {
        _infix = infix.Split(' ');
        _cmd = null;
        Hashtable _command_set = new Hashtable();
        _command_set.Add("+", new MethodChooser(factory.CreateAddCommand));
        _command_set.Add("-", new MethodChooser(factory.CreateSubtractCommand));
        _command_set.Add("/", new MethodChooser(factory.CreateDivideCommand));
        _command_set.Add("*", new MethodChooser(factory.CreateMultiplyCommand));
        _command_set.Add("%", new MethodChooser(factory.CreateModulusCommand));

        foreach (string _input in _infix)
        {
            try
            {
                temp = Convert.ToInt32(_input);
                _cmd = factory.CreateNumberCommand(temp);   
            }
            catch (FormatException)
            {
                if (_command_set.ContainsKey(_input))
                {
                    _cmd = ((MethodChooser)_command_set[_input])();
                }
                // Only other input should be ')' and '(' which will roll down to shunting yard.
            }
/************* Shunting Yard Algorithm****************/
            switch (_input)
            {
                case "(":
                    _temp_stack.Push(null);
                    break;
                case ")":
                    while (_temp_stack.Count > 0)
                    {
                        if (_temp_stack.Peek() != null)
                        {
                            postfix.Push(_temp_stack.Pop());
                        }
                        else
                        {
                            _temp_stack.Pop();
                        }
                    }
                    break;
                case "+":
                case "-":
                    if (_temp_stack.Count > 0 && _temp_stack.Peek() != null)
                    {
                        postfix.Push(_temp_stack.Pop());
                        _temp_stack.Push(_cmd);
                    }
                    else
                    {
                        _temp_stack.Push(_cmd);
                    }
                    break;
                case "*":
                case "/":
                case "%":
                    _temp_stack.Push(_cmd);
                    break;
                default: //a number, by elimination, if my input and parsing are correct.
                    postfix.Push(_cmd);
                    break;
            }
        }
        foreach (Command item in _temp_stack)
        {
            if (item != null)
                postfix.Push(item);
        }

    }
}