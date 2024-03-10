using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;



namespace CalculatorDemo.ViewModels
{
    public class CalculatorViewModel : INotifyPropertyChanged
    {
        private double _number1;

        private double _number2;

        private string _operand = "";

        private string _result = "";

        public string Result
        {
            get { 
                return _result;
            }

            set {
                _result = value;
               // OnPropertyChanged(nameof(Result));
            }
        }

        public void AddOperation (object? operand)
        {
            string stringOperand = operand.ToString();

            if (_operand == "")
            {
                if (double.TryParse(Result, out _number1) == false) return;
            }
            else
            {
                if (double.TryParse(Result, out _number2) == false) return;
                // OperClick();
                _number1 = double.Parse(Result);
            }

            if (stringOperand == "n!" || stringOperand == "floor" || stringOperand == "tan" || stringOperand == "log" || stringOperand == "ln" || stringOperand == "sin" || stringOperand == "cos" || stringOperand == "ceil")
            {
                if(double.TryParse(Result, out _number1) == false) return;
                _operand = stringOperand;
                //OperClick();
                return;
            }
            _operand = stringOperand;
            Result = "";
        }



        public void AddNumber(object? value)
        {
            if(value == null) return;
            string stringValue = value.ToString();

            if(string.IsNullOrEmpty(Result) && stringValue == "-")
            {
                Result += stringValue;
                return;
            }

            if (stringValue == "-" && Result.Contains("-"))
            {
                return;
            }

            if(stringValue == "," && !stringValue.Contains(","))
            {
                stringValue = "0" + stringValue;
            }

            if(stringValue == "," && Result.Contains(","))
            {
                return;
            }

            Result += stringValue;
        }

        public void Clear()
        {
            _number1 = 0;
            _number2 = 0;
            _operand = "";
            _result = "";
        }

        public void OperClick()
        {
            if (double.TryParse(Result, out _number2) == false) return;

            switch (_operand)
            {
                case "+":
                    Result = (_number1 + _number2).ToString();
                    break;
                case "-":
                    Result = (_number1 - _number2).ToString();
                    break;
                case "*":
                    Result = (_number1 * _number2).ToString();
                    break;
                case "/":
                    if(_number2 != 0) {
                        Result = (_number1 / _number2).ToString();
                    }
                    else
                    {
                        Result = "E";
                        return;
                    }
                    break; 
                case "mod":
                    if (_number2 != 0)
                    {
                        Result = (_number1 / _number2).ToString();
                    }
                    else
                    {
                        Result = "E";
                        return;
                    }
                    break;
                case "^":
                        Result = Math.Pow(_number1, _number2).ToString();
                    break;
                case"floor":
                    Result = Math.Floor(_number1).ToString();
                    break;
                case"sin":
                    Result = Math.Sin(_number1).ToString();
                    break;
                case"cos":
                    Result = Math.Cos(_number1).ToString();
                    break;
                case"tan":
                    Result = Math.Tan(_number1).ToString();
                    break;
                case"log":
                    if (_number1 > 0)
                    {
                        Result = Math.Log(_number1).ToString();
                    }
                    else
                    {
                        Result = "E";
                        return;
                    }
                    break;
                case "ln":
                    if (_number1 > 0)
                    {
                        Result = Math.Log10(_number1).ToString();
                    }
                    else
                    {
                        Result = "E";
                        return;
                    }
                    break;
                case"ceil":
                    Result = Math.Ceiling(_number1).ToString();
                    break;
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }


       
    
}
