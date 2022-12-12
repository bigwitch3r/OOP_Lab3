using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab3
{
    internal class FacadeClass
    {
        public void Class(FacadeLearningProcess facadeLearningProcess)
        {
            facadeLearningProcess.Start();
            facadeLearningProcess.Stop();
        }
    }
}
