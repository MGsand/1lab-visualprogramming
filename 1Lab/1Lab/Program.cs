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


    public void AddNotifyer(decimal Notyfier)
    {
        _notyfiers.Add(Notyfier);
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
        Account();
        //Account(20000);
    }




};



