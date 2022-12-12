using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab3
{
    internal class FacadeEducator
    {
        public string Name { get; set; }

        public void StartTeaching()
        {
            Console.WriteLine($"Преподаватель {Name} начал проведение занятия.");
        }

        public void StopTeaching()
        {
            Console.WriteLine($"Преподаватель {Name} закончил проведение занятия.");
        }

        public FacadeEducator(string name)
        {
            Name = name;
        }
    }
}
