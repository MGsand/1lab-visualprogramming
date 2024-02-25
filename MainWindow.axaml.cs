using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using CalculatorDemo.ViewModels;

namespace CalculatorDemo
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new CalculatorViewModel();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}