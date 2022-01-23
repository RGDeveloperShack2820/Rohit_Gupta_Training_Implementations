using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Implementation.Observer_Pattern
{
    internal class Subjects
    {
        List<Observer> observers = new List<Observer>();
        int state;

        public int getState()
        {
            return state;
        }

        public void setState(int state)
        {
            this.state = state;
            notifyAll();
        }

        public void addObserver(Observer observer)
        {
            observers.Add(observer);
        }

        public void notifyAll()
        {
            foreach (Observer observer in observers)
            {
                observer.update();
            }
        }


    }
}
