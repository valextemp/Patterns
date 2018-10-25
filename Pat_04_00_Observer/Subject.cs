using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pat_04_00_Observer
{
    abstract class Subject
    {
        List<Observer> observers = new List<Observer>();
        public virtual void Attach(Observer observer)
        {
            observers.Add(observer);
            observer.Update(this);
        }

        public virtual void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        public virtual void Notify()
        {
            foreach (Observer item in observers)
            {
                item.Update(this);
            }
        }

        
    }
}
