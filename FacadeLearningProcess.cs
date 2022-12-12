using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab3
{
    internal class FacadeLearningProcess
    {
        FacadeCleaner cleaner;
        FacadeStudent student;
        FacadeEducator educator;

        public FacadeLearningProcess(FacadeCleaner cleaner, FacadeStudent student, FacadeEducator educator)
        {
            this.cleaner = cleaner;
            this.student = student;
            this.educator = educator;
        }

        public void Start()
        {
            cleaner.StartCleaning();
            cleaner.StopCleaning();
            
            student.StartLearning();
            educator.StartTeaching();
        }

        public void Stop() 
        {
            educator.StopTeaching();
            student.StopLearning();

            cleaner.StartCleaning();
            cleaner.StopCleaning();
        }
    }
}
