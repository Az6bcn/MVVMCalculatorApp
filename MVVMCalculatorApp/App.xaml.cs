using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MVVMCalculatorApp.Services;
using MVVMCalculatorApp.Views;

namespace MVVMCalculatorApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<CalculatorOperationsService>();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
