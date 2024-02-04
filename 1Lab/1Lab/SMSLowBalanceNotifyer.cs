using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Lab
{
    internal class SMSLowBalanceNotifyer : INotyfier
    {
        private decimal _lowBalanceValue;
        private string _phone;



        public SMSLowBalanceNotifyer(string phone, decimal lowBalanceValue)
        {
            this._phone = phone;
            _lowBalanceValue = lowBalanceValue;
        }

        public void Notify(decimal _balance)
        {
            if (_balance < _lowBalanceValue)
            {
                Console.WriteLine($"Метод Notify вызван из класса SMSLowBalanceNotifyer. Баланс: {_balance}; Телефон: {_phone}; Нижний порог: {_lowBalanceValue}");
            }
        }


    }
}
