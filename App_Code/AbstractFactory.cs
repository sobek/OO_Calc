using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Abstract class describes products created by factory.
/// </summary>
public abstract class AbstractFactory
{

     public abstract Command CreateNumberCommand(int number);
     public abstract Command CreateAddCommand();
     public abstract Command CreateSubtractCommand();
     public abstract Command CreateMultiplyCommand();
     public abstract Command CreateDivideCommand();
     public abstract Command CreateModulusCommand();
}