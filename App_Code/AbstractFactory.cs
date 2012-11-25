using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Abstract class describes products created by factory.
/// </summary>
public abstract class AbstractFactory
{

     public abstract NumberCommand CreateNumberCommand(int number);
     public abstract AddCommand CreateAddCommand();
     public abstract SubtractCommand CreateSubtractCommand();
     public abstract MultiplyCommand CreateMultiplyCommand();
     public abstract DivideCommand CreateDivideCommand();
     public abstract ModulusCommand CreateModulusCommand();
}