// See https://aka.ms/new-console-template for more information
using _1Lab;

class  account{
    private decimal _balance;
    private List<INotyfier>? _notyfiers;


   public decimal Balance
    {
        get
        {
            return _balance;
        }
    }

    public void Account()
    {
        Console.WriteLine("Создание объекта Account");
        _notyfiers = new List<INotyfier>();
        _balance = 0;
    }

    public void Account(decimal in_balance)
    {
        Console.WriteLine("Создание объекта Account");
        _notyfiers = new List<INotyfier>();
        _balance = in_balance;
    }


    public void AddNotifyer()
    {
        _notyfiers.Add(INotyfier);
    }


    public void ChangeBalance(decimal value) {
        value = Convert.ToDecimal(Console.ReadLine());
        _balance = _balance + value;
    }

    public void Notifycation()
    {
        foreach (var INotyfier in _notyfiers)
        {
            Console.WriteLine(INotyfier);
        }
    }


    static void Main()
    {
        Account acc = new Account(100.0m);
        SMSLowBalanceNotifyer smsNotifyer = new SMSLowBalanceNotifyer("+7-999-888-77-66", 50.0m);
        EMailNotifyer emailNotifyer = new EMailNotifyer("mileschko.sibsutis@yandex.ru");

        acc.AddNotifyer(smsNotifyer);
        acc.AddNotifyer(emailNotifyer);

        acc.ChangeBalance(10);
        acc.ChangeBalance(-30);
        acc.ChangeBalance(-70);
    }




};



