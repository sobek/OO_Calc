using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Return concrete classes; creating a new class for each request.
/// </summary>

public class BasicFactory : AbstractFactory
{
	public BasicFactory()
	{
	}
    private BasicFactory(Command cmd)
    { 
        //Prevent calling constructor with Command type.
    }
    override public Command CreateNumberCommand(int number)
    {
        return new NumberCommand(number);
    }
    
    override public Command CreateAddCommand()
    {
        return new AddCommand();
    }
    
    override public Command CreateSubtractCommand()
    {
        return new SubtractCommand();    
    }
      
    override public Command CreateMultiplyCommand()
    {
        return new MultiplyCommand();
    }
       
    override public Command CreateDivideCommand()
    {
        return new DivideCommand();
    }
       
    override public Command CreateModulusCommand()
    {
        return new ModulusCommand();    
    }
   
}
