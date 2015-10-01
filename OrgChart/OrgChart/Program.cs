using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrgChart
{

    class Employee
    {
        public string name { get; set; }
        public int ReportCount { get; set; }
    }

    class EmployeeType
    {
        public List<Employee> EmployeeList { get; set; }

        public EmployeeType()
        {

            EmployeeList = new List<Employee>();

            EmployeeList.Add(new Employee { name = "Bill", ReportCount = 3 });
            EmployeeList.Add(new Employee { name = "Sam", ReportCount = 0 });
            EmployeeList.Add(new Employee { name = "Fred", ReportCount = 1 });
            EmployeeList.Add(new Employee { name = "Jane", ReportCount = 0 });
            EmployeeList.Add(new Employee { name = "Alice", ReportCount = 0 });

        }


        public Employee Lookup(int ReportCount)
        {
            for (int i = 0; i < EmployeeList.Count; i++)
            {
                if (EmployeeList[i].ReportCount == ReportCount)
                {

                   return EmployeeList[i];
                    
                }
            }
            return null;
                    }


        class Program
        {
            static void Main(string[] args)
            {
                Debug.Assert(new EmployeeType().Lookup(3).ReportCount == 3, "Not true");

            }
        }
    }
}
