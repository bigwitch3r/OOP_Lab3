
namespace OOP_Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* !!!!! Observer Pattern !!!!!
             * ObserverClass currentclass = new ObserverClass();

            ObserverEducator educator = new ObserverEducator("Сан Саныч", currentclass);
            ObserverStudent student = new ObserverStudent("Данил Алексеевич", currentclass);

            currentclass.LearningProcess();

            student.StopLearning();

            currentclass.LearningProcess();*/

            /* !!!!! FACADE PATTERN !!!!!
             * FacadeCleaner cleaner = new FacadeCleaner("Иванов И. И.");
            FacadeEducator educator = new FacadeEducator("Петров И. И.");
            FacadeStudent student = new FacadeStudent("Сидоров И. И.");

            FacadeLearningProcess facadeLearningProcess = new FacadeLearningProcess(cleaner, student, educator);

            FacadeClass currentclass = new FacadeClass();
            currentclass.Class(facadeLearningProcess);*/

            FactoryMember student = new FactoryStudent("Гончаров Д. А.");
            FactorySalary studentSalary = student.PaySalary();

            FactoryMember educator = new FactoryEducator("Иванов И. И.");
            FactorySalary educatorSalary = educator.PaySalary();

        }
    }
}
