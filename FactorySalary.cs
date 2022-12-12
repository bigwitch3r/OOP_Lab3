using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab3
{
    abstract class FactorySalary
    {
        public int Amount { get; set; }

        public FactorySalary(int amount)
        {
            Amount = amount;
        }
    }
}
