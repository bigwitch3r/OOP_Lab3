using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab3
{
    internal class FactoryStudent : FactoryMember
    {
        public FactoryStudent(string name) : base(name)
        {
            
        }

        public override FactorySalary PaySalary()
        {
            return new FactoryStudentSalary(3600);
        }
    }
}
