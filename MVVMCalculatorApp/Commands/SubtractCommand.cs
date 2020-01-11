using System;
using System.Windows.Input;
using MVVMCalculatorApp.Services;
using MVVMCalculatorApp.ViewModels;

namespace MVVMCalculatorApp.Commands
{
    public class SubtractCommand: ICommand
    {
        public CalculatorViewModel _calculatorViewModel { get; set; }
        public SubtractCommand(CalculatorViewModel calculatorViewModel)
        {
            _calculatorViewModel = calculatorViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _calculatorViewModel.Subtract();
        }
    }
}
