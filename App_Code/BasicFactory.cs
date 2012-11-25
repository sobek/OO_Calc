using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Return concrete classes
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
    override public NumberCommand CreateNumberCommand(int number)
    {
        return new NumberCommand(number);
    }
    
    override public AddCommand CreateAddCommand()
    {
        return new AddCommand();
    }
    
    override public SubtractCommand CreateSubtractCommand()
    {
        return new SubtractCommand();    
    }
      
    override public MultiplyCommand CreateMultiplyCommand()
    {
        return new MultiplyCommand();
    }
       
    override public DivideCommand CreateDivideCommand()
    {
        return new DivideCommand();
    }
       
    override public ModulusCommand CreateModulusCommand()
    {
        return new ModulusCommand();    
    }
   
}
