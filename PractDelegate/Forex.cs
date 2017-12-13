using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractDelegate
{
    public delegate void Handler(int message);
  public  class Forex
    {
        private Handler handler;
        public int Stock { get; set; }


        public void RegisterHandler(Handler handler)
        {
            //  Delegate newHandler = Delegate.Combine(handler, this.handler);
            // this.handler = newHandler as AccountHandler;
            //this.handler = handler;
            this.handler += handler;
        }


        public void Buy(int stock)
        {
            Stock--;
        }

        public void Sell(int money)
        {
            Stock++;
            if (handler != null)
            {
                handler.Invoke(money);
            }
        }
    }
}
