using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab3
{
    internal class FacadeCleaner
    {
        public string Name { get; set; }

        public void StartCleaning()
        {
            Console.WriteLine($"{Name} начал уборку аудитории.");
        }

        public void StopCleaning()
        {
            Console.WriteLine($"{Name} закончил уборку аудитории.");
        }

        public FacadeCleaner(string name)
        {
            Name = name;
        }
    }
}
