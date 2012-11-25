using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Interface describes products created by factory.
/// </summary>
interface AbstractFactory
{

     NumberCommand CreateNumberCommand(int number);
     AddCommand CreateAddCommand();
     SubtractCommand CreateSubtractCommand();
     MultiplyCommand CreateMultiplyCommand();
     DivideCommand CreateDivideCommand();
     ModulusCommand CreateModulusCommand();
}