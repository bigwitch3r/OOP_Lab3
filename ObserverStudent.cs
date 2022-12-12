using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab3
{
    internal class ObserverStudent : IObserver
    {
        public string Name { get; set; }

        IObservable currentclass;

        public ObserverStudent(string name, IObservable obs)
        {
            Name = name;
            currentclass = obs;
            currentclass.AddObserver(this);
        }

        public void Update(object ob)
        {
            ObserverClassInfo classInfo = ob as ObserverClassInfo;

            Console.WriteLine($"Студент {Name} присутствует на занятии {classInfo.Name}.");
            Console.WriteLine($"Дата и время занятия: {classInfo.DateTime}.");
        }

        public void StopLearning()
        {
            currentclass.RemoveObserver(this);
            currentclass = null;
        }
    }
}
