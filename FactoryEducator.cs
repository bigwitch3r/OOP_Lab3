using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab3
{
    internal class FactoryEducator : FactoryMember
    {
        public FactoryEducator(string name) : base(name) 
        {

        }

        public override FactorySalary PaySalary()
        {
            return new FactoryEducatorSalary(100000);
        }
    }
}
