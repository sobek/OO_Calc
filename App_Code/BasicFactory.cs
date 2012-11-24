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
    public NumberCommand CreateNumberCommand(int number)
    {
        return new NumberCommand(number);
    }
    
    public AddCommand CreateAddCommand()
    {
        return new AddCommand();
    }
    
    public SubtractCommand CreateSubtractCommand()
    {
        return new SubtractCommand();    
    }
      
    public MultiplyCommand CreateMultiplyCommand()
    {
        return new MultiplyCommand();
    }
       
    public DivideCommand CreateDivideCommand()
    {
        return new DivideCommand();
    }
       
    public ModulusCommand CreateModulusCommand()
    {
        return new ModulusCommand();    
    }
   
}
