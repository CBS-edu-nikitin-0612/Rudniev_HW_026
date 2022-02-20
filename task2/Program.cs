using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите информацию о работниках в формате 'Петров В.B, junior dev, 2020'. " +
                "По одному работнику на строке: ");
            Worker[] workers = InputInfoOfWorkers(5);
            workers = workers.SortWorkersArray();
            Console.Write("Введите кол-во отработанных лет: ");
            OutputWorkersByExperience(workers, Convert.ToInt32(Console.ReadLine()));
        }
        static Worker[] InputInfoOfWorkers(int workersLength)
        {
            Worker[] workers = new Worker[workersLength];
            for (int i = 0; i < workers.Length; i++)
            {
                try
                {
                    workers[i] = Worker.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    i--;
                }
            }
            return workers;
        }
        static void OutputWorkersByExperience(Worker[] workers, int experience)
        {
            Console.WriteLine("Работники, стаж которых превышает введеное значение: ");
            foreach (Worker element in workers)
                if ((DateTime.Now.Year - element.BeginningOfWork) > experience)
                    Console.WriteLine(element);
        }
    }
    
}

