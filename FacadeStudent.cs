using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab3
{
    internal class FacadeStudent
    {
        public string Name { get; set; }

        public void StartLearning()
        {
            Console.WriteLine($"Студент {Name} прибыл на занятие.");
        }

        public void StopLearning()
        {
            Console.WriteLine($"Студент {Name} покинул занятие.");
        }

        public FacadeStudent(string name)
        {
            Name = name;
        }
    }
}
