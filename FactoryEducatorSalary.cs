using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab3
{
    internal class FactoryEducatorSalary : FactorySalary
    {

        public FactoryEducatorSalary(int amount) : base(amount)
        {
            Console.WriteLine($"Выплачена зарплата в размере {amount} руб.");
        }
    }
}
