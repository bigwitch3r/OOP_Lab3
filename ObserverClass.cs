using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab3
{
    internal class ObserverClass : IObservable
    {
        ObserverClassInfo classInfo;

        List<IObserver> observers;

        public ObserverClass()
        {
            observers = new List<IObserver>();
            classInfo= new ObserverClassInfo();
        }

        public void AddObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (IObserver o in observers)
            {
                o.Update(classInfo);
            }
        }

        public void LearningProcess()
        {
            classInfo.Name = "Introduction to Neural Networks";
            classInfo.DateTime = "Понедельник, 13:40 - 15:10";
            NotifyObservers();
        }
    }
}
