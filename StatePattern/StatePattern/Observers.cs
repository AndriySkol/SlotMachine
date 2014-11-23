using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public interface Observer
    {
        void Update(Observable observable);
    }
    public abstract class Observable
    {
        List<Observer> listOfObservers = new List<Observer>();

        public void add(Observer observer)
        {
            listOfObservers.Add(observer);
        }
        public void NotifyObservers()
        {
            foreach(var x in listOfObservers)
            {
                x.Update(this);
            }
        }
    }

}
