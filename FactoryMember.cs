using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab3
{
    abstract class FactoryMember
    {
        public string Name { get; set; }

        public FactoryMember(string name)
        {
            Name = name;
        }

        abstract public FactorySalary PaySalary();
    }
}
