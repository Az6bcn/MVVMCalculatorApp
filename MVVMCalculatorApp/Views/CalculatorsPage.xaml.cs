using System;
using System.Collections.Generic;
using MVVMCalculatorApp.ViewModels;
using Xamarin.Forms;

namespace MVVMCalculatorApp.Views
{
    public partial class CalculatorsPage : ContentPage
    {

        public CalculatorsPage()
        {
            InitializeComponent();

            BindingContext = new CalculatorViewModel();
        }
    }
}
