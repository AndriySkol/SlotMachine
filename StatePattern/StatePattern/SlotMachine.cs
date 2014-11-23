using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class SlotMachine: Observable
    {
        public State State { get; set; }
        public int MoneyPut { get; set; }
        public int GetBox { get; set; }
        public string Text { get; set; }
        public int X1 { get; set; }
        public int X2 { get; set; }
        public int X3 { get; set; }

        public SlotMachine()
        {
            State = new NoMoney(this);
        }
        public void PutMoney(int money)
        {
            State.PutMoney(money);
            NotifyObservers();

        }

        public void Try()
        {
            State.MakeTrial();
            NotifyObservers();

        }

        public void GetMoney()
        {
            State.GetMoneyBack();
            NotifyObservers();
        }

        public void TakeMoney()
        {
            State.TakeMoney();
            NotifyObservers();

        }

    }
}
