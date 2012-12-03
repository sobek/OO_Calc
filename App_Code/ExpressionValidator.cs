using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

/// <summary>
/// Summary description for ExpressionValidator
/// </summary>
public class ExpressionValidator
{
    string _expression;
    string[] _split_expression;
	public ExpressionValidator(string expression)
	{
        _expression = expression;
    }
    
    public bool validation(ref string error)
    {
        Regex _invalid_tokens = new Regex(@"[^0-9a-z/+///*/%-\//()]?-i]");
        Regex _valid_digits = new Regex(@"[0-9]");
        Regex _valid_variables = new Regex(@"[a-j]?-i");
        Regex _valid_operators = new Regex(@"[///+/*/%-/(/)]");
        if (_expression != null)
        {
            _split_expression = _expression.Split(' ');
            for (int i = 0; i < _split_expression.Length; i++)
            {
                if (_invalid_tokens.Match(_split_expression[i]).Success)
                {
                    error = "Your expression contains invalid characters: ' " + _invalid_tokens.Match(_split_expression[i]) + "'";
                    return true;
                }
                else if (_valid_digits.IsMatch(_split_expression[i]) && (_valid_variables.IsMatch(_split_expression[i]) || _valid_operators.IsMatch(_split_expression[i])))
                {
                    error = "Please separate all values with a proper space.";
                    return true;
                }
                else if (_split_expression[i] == "/" && _split_expression[i+1] == "0")
                {
                    //very BASIC divide by zero detection.  Must add exception handling in InfixToPostfix for stronger support
                    error = "You can't divide by zero.  The asymptotes approach both positive and negative infinity.";
                    return true;
                }
                else if (_split_expression[i] == "(" || _split_expression[i] == ")") //&& ((i > 0 && _valid_operators.Match(_split_expression[i - 1]).Success) || (i < _split_expression.Length &&_valid_operators.Match(_split_expression[i+1]).Success)
                {
                    if (i > 0 && _valid_operators.Match(_split_expression[i - 1]).Success)
                    {
                        error = "Please check your expression for proper values around parentheses.";
                        return true;
                    }
                }
            }
            if (Regex.Matches(_expression, @Regex.Escape(")")).Count != Regex.Matches(_expression, @Regex.Escape("(")).Count)
            {
                error = "Parentheses do not match";
                return true;
            }
        }
        return false;
	}
}