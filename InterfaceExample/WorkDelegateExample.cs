using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public delegate void WorkStatus();

    public class DelegateManager
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

    public class DelegateEmployee
    {
        public WorkStatus WorkStarted;
        public WorkStatus WorkEnded;

        public void EmployeeDoWork()
        {
            Console.WriteLine("Employee started work.");

            // notify manager
            if (WorkStarted != null)
            {
                WorkStarted();
            }

            Console.WriteLine("Employee ended work.");

            if (WorkEnded != null)
            {
                WorkEnded();
            }
        }
    }
}
