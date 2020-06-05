using System;

namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // example of interface

            //Manager manager = new Manager();
            //Employee employee = new Employee(manager);

            //employee.EmployeeDoWork();


            // example of delegate
            DelegateManager delegateManager = new DelegateManager();
            DelegateEmployee delegateEmployee = new DelegateEmployee();

            delegateEmployee.WorkStarted = delegateManager.StartWork;
            delegateEmployee.WorkEnded = delegateManager.EndWork;

            delegateEmployee.EmployeeDoWork();
        }
    }
}
