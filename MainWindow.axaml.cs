using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using CalculatorDemo.ViewModels;

namespace CalculatorDemo
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new CalculatorViewModel();
        }
        //<Button Content="Back" Command="{Binding }" Margin="10" Grid.Column="1" Grid.Row="4"/>
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}