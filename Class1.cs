using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CalculatorDemo.ViewModels
{
    public class CalculatorViewModel : INotifyPropertyChanged
    {
        public string Input { get; set; } = "";

        public ICommand NumberButtonCommand { get; }
        public ICommand OperationButtonCommand { get; }
        public ICommand EqualsButtonCommand { get; }
        public ICommand ClearButtonCommand { get; }
        public ICommand BackButtonCommand { get; }

        public CalculatorViewModel()
        {
            NumberButtonCommand = new RelayCommand<string>(AddNumber);
            OperationButtonCommand = new RelayCommand<string>(AddOperation);
            EqualsButtonCommand = new RelayCommand(Equals);
            ClearButtonCommand = new RelayCommand(Clear);
            BackButtonCommand = new RelayCommand(Back);
        }

        private void AddNumber(string number)
        {
            Input += number;
        }

        private void AddOperation(string operation)
        {
            Input += operation;
        }

        private void Equals()
        {
            // Добавьте логику для =
        }

        private void Clear()
        {
            Input = "";
        }

        private void Back()
        {
            if (Input.Length > 0)
            {
                Input = Input.Substring(0, Input.Length - 1);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}