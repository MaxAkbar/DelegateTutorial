using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public interface IWork
    {
        void StartWork();
        void EndWork();
    }

    public class Manager : IWork
    {
        public void StartWork()
        {
            Console.WriteLine("Manager notificed of work started.");
        }

        public void EndWork()
        {
            Console.WriteLine("Manager notificed of work ended.");
        }
    }

    public class Employee
    {
        private IWork work;

        public Employee(IWork work)
        {
            this.work = work;
        }

        public void EmployeeDoWork()
        {
            Console.WriteLine("Employee started work.");

            // notify manager
            work.StartWork();

            Console.WriteLine("Employee ended work.");
        }
    }
}
