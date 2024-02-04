using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Lab
{
    internal class EMailbalanceChanged : INotyfier
    {
        private string _email;

        public void Email(string email)
        {
            _email = email;
        }
        public void Notify(decimal _balance)
        {
            Console.WriteLine($"Более подробная информация отправлена на вашу почту : {_email}");
        }
    }
}
