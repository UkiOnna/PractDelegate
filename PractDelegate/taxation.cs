using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractDelegate
{
   // public delegate void Handler(int message);
    public class Taxation
    {

       // private Handler handler;
        public int Percent { get; set; }

        public void GetPay(int money)
        {
            money = (money/100)*Percent;//12,5 процентов
            Console.WriteLine("Было снято - "+money);
            Console.ReadLine();
        }
    }
}
