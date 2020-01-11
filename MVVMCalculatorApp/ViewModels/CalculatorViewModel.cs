
using System.ComponentModel;
using MVVMCalculatorApp.Commands;
using MVVMCalculatorApp.Models;
using MVVMCalculatorApp.Services;

namespace MVVMCalculatorApp.ViewModels
{
    public class CalculatorViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public CalculatorModel Calculator { get; set; }
        private ICalculatorOperationsService _operationsService;

        public AddCommand AddCommand { get; set; }
        public SubtractCommand SubtractCommand { get; set; }
        public MultiplyCommand MultiplyCommand { get; set; }
        public DivideCommand DivideCommand { get; set; }

        public CalculatorViewModel(ICalculatorOperationsService operationsService = null)
        {
            Calculator = new CalculatorModel();
            _operationsService = operationsService ?? new CalculatorOperationsService();

            AddCommand = new AddCommand(this);
            SubtractCommand = new SubtractCommand(this);
            MultiplyCommand = new MultiplyCommand(this);
            DivideCommand = new DivideCommand(this);
        }


        //fire property changed event:
        public void OnPropertyChanged(string changedProperty)
        {
            // raise event
            PropertyChanged(this, new PropertyChangedEventArgs(changedProperty));
        }

        public int Num1
        {
            get { return Calculator.NumberOne; }
            set{
                if(Calculator.NumberOne != value)
                {
                    Calculator.NumberOne = value;
                    // value has changed: fire event
                    OnPropertyChanged(nameof(Num1));
                }
            }
        }

        public int Num2
        {
            get { return Calculator.NumberTwo; }
            set
            {
                if (Calculator.NumberTwo != value)
                {
                    Calculator.NumberTwo = value;
                    // value has changed: fire event
                    OnPropertyChanged(nameof(Num2));
                    
                }
            }
        }

        public int Result
        {
            get{return Calculator.Result;}
            set
            {
                if(Calculator.Result != value)
                {
                    Calculator.Result = value;
                    // value has changed: fire event
                    OnPropertyChanged(nameof(Result));
                }
            }
        }

        public void Add()
        {
            Result = _operationsService.Add(Num1, Num2);
        }
        public void Subtract()
        {
            Result = _operationsService.Subtract(Num1, Num2);
        }
        public void Multiply()
        {
            Result = _operationsService.Multiply(Num1, Num2);
        }
        public void Divide()
        {
            Result = _operationsService.Divide(Num1, Num2);
        }

    }
}