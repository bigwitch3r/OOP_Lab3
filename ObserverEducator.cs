using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab3
{
    internal class ObserverEducator : IObserver
    {
        public string Name { get; set; }

        IObservable currentclass;

        public ObserverEducator(string name, IObservable obs)
        {
            Name = name;
            currentclass = obs;
            currentclass.AddObserver(this);
        }

        public void Update(object ob)
        {
            ObserverClassInfo classInfo = ob as ObserverClassInfo;

            Console.WriteLine($"Преподаватель {Name} преподаёт урок {classInfo.Name}.");
            Console.WriteLine($"Дата и время занятия: {classInfo.DateTime}.");
        }
    }
}
