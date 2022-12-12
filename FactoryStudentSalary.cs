using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab3
{
    internal class FactoryStudentSalary : FactorySalary
    {
        public FactoryStudentSalary(int amount) : base(amount)
        {
            Console.WriteLine($"Выплачена стипендия в размере {amount} руб.");
        }
    }
}
