using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Fix Return!  I am not returning anything useful!

/// <summary>
/// Command interface contains excute which returns a boolean value.
/// </summary>
/// 

public interface Command
{
    bool Execute(Stack <int> stack);
}
public abstract class BinaryOperationCommand : Command
{
    public abstract int Evaluate(int n1, int n2);

    public bool Execute(Stack<int> stack)
    {
        int _n1 = stack.Pop();
        int _n2 = stack.Pop();
        int _result = Evaluate(_n1, _n2);
        stack.Push(_result);
        return true;
    }
}

public class NumberCommand : Command
{
    private int _n1;

    public NumberCommand(int number)
    {
        _n1 = number;
    }

    public bool Execute(Stack<int> stack)
    {
        stack.Push(_n1);
        return true;
    }
}

/**************************************************
**************** Binary Commands ******************
**************************************************/

public class AddCommand : BinaryOperationCommand
{
    public AddCommand()
    {
        //blank
    }

    public override int Evaluate(int n1, int n2)
    {
        return n1 + n2;
    }

}

public class SubtractCommand : BinaryOperationCommand
{
    public SubtractCommand()
    {
        //blank
    }

    public override int Evaluate(int n1, int n2)
    {
        return n2 - n1;
    }
}

public class MultiplyCommand : BinaryOperationCommand
{
    public MultiplyCommand()
    {
    }

    public override int Evaluate(int n1, int n2)
    {
        return n1 * n2;
    }
}

public class DivideCommand : BinaryOperationCommand
{
    public DivideCommand()
    {
    }

    public override int Evaluate(int n1, int n2)
    {
        return n1 / n2;
    }
}

public class ModulusCommand : BinaryOperationCommand
{
    public ModulusCommand()
    {
    }

    public override int Evaluate(int n1, int n2)
    {
        return n2 % n1;
    }
}

/**************************************************
**************** Unary Commands *******************
**************************************************/