using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public struct Worker
    {
        private string surnameAndInitials;
        private string position;
        private int beginningOfWork;

        public int BeginningOfWork { get => beginningOfWork; set => beginningOfWork = value; }
        public string Position { get => position; set => position = value; }
        public string SurnameAndInitials { get => surnameAndInitials; set => surnameAndInitials = value; }
    
        public Worker(string surnameAndInitials, string position, int beginningOfWork)
        {
            this.surnameAndInitials = surnameAndInitials;
            this.position = position;
            this.beginningOfWork = beginningOfWork;
        }
        public static Worker Parse(string infoOfWorker)
        {
            string[] infoArgs = infoOfWorker.Split(",");
            for (int i = 0; i < infoArgs.Length; i++)
                infoArgs[i] = infoArgs[i].Trim();
            if (infoArgs.Length != 3)
                throw new Exception("Wrong data format");

            int beginningOfWork;
            if (!int.TryParse(infoArgs[2], out beginningOfWork))
                throw new Exception("Wrong year format");

            return new Worker(infoArgs[0], infoArgs[1], beginningOfWork);
        }

        public override string ToString()
        {
            return surnameAndInitials;
        }
    }
    public static class WorkerExtension
    {
        public static Worker[] SortWorkersArray(this Worker[] workers)
        {
            Worker[] temp = new Worker[workers.Length];
            string[] surnameArray = new string[workers.Length];
            for (int i = 0; i < workers.Length; i++)
                surnameArray[i] = workers[i].SurnameAndInitials;
            Array.Sort(surnameArray);
            for (int i = 0; i < surnameArray.Length; i++)
                foreach (Worker element in workers)
                    if (element.SurnameAndInitials == surnameArray[i])
                        temp[i] = element;

            return temp;
        }
    }
}
