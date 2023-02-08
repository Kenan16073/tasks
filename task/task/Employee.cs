using System;
using System.Collections.Generic;
using System.Text;

namespace task
{
    internal class Employee
    {
        public string FullName;
        private int _salary;
        public int Salary
        {
            get 
            {
                return _salary; 
            }
            set
            {
                if(value>=300)
                    _salary = value;
            }

        }


    }
}
