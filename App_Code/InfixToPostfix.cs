using System;
using System.Collections.Generic;
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

    public InfixToPostfix(AbstractFactory factory, ref Stack<Command> postfix, string infix)
    {
        _infix = infix.Split(' ');
        _cmd = null;

        foreach (string _input in _infix)
        {
            switch (_input)
            {
                case "+":
                    _cmd = factory.CreateAddCommand();
                    break;
                case "-":
                    _cmd = factory.CreateSubtractCommand();
                    break;
                case "*":
                    _cmd = factory.CreateMultiplyCommand();
                    break;
                case "/":
                    _cmd = factory.CreateDivideCommand();
                    break;
                case "%":
                    _cmd = factory.CreateModulusCommand();
                    break;
                case "(":
                case ")":
                    _cmd = null;
                    break;
                default:
                    int _input_to_int = Convert.ToInt32(_input); 
                    _cmd = factory.CreateNumberCommand(_input_to_int);
                    break;
            }
/************* Shunting Yard Algorithm****************/
            switch (_input)
            {
                case "(":
                    _temp_stack.Push(_cmd); //pushes null
                    break;
                case ")":
                    do
                    {
                        _temp_stack.Pop();
                        postfix.Push(_cmd);
                    } while (_temp_stack.Count > 0);
                    _temp_stack.Pop();  //should remove null from _temp_stack.
                    break;
                case "+":
                case "-":
                    if (_temp_stack.Count() > 0)
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