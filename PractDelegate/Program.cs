using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractDelegate
{
   public class Program
    {
       static void Main(string[] args)
        {
            //List<BankAccount> accounts = new List<BankAccount>();

            //accounts.OrderBy(account => account.Sum);
            //accounts.ForEach(account => Console.WriteLine(account.Sum));
            //accounts.FirstOrDefault(account => account.Sum > 0);

            int money = 1000;
            Person person = new Person();
            person.Money = money;
            Forex forex = new Forex();
            forex.Stock = 5;
            forex.Sell(person.Money);
            Taxation taxation = new Taxation();
            taxation.Percent = 13;
            taxation.GetPay(money);
            forex.RegisterHandler(new Handler(taxation.GetPay));
        }
    }
}
