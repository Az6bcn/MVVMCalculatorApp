using System;
namespace MVVMCalculatorApp.Services
{
    public interface ICalculatorOperationsService
    {
        int Add(int num1, int num2);
        int Subtract(int num1, int num2);
        int Multiply(int num1, int num2);
        int Divide(int num1, int num2);
    }
}
