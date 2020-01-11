
using System.ComponentModel;
using MVVMCalculatorApp.Models;

namespace MVVMCalculatorApp.ViewModels
{
    public class CalculatorViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        //fire property changed event:
        public void OnPropertyChanged(string changedProperty)
        {
            // raise event
            PropertyChanged(this, new PropertyChangedEventArgs(changedProperty));
        }

        public CalculatorModel Calculator { get; set; }


        public CalculatorViewModel()
        {
            Calculator = new CalculatorModel();
        }

        public int Num1
        {
            get{
                return Calculator.NumberOne;
            }
            set{
                if(Calculator.NumberOne != value)
                {
                    Calculator.NumberOne = value;
                    // value has changed: fire event
                    OnPropertyChanged(nameof(Num1));
                    OnPropertyChanged(nameof(Sum));
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
                    OnPropertyChanged(nameof(Sum));
                }
            }
        }

        public int Sum
        {
            get
            {
                return Num1 + Num2;
            }
        }
    }
}