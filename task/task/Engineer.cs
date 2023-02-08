using System;
using System.Collections.Generic;
using System.Text;

namespace task
{
    internal class Engineer:Employee
    {
        public int _salary
        {
            get 
            {
                return _salary;
            } 
            set
            {
                if (value>=1000)
                    _salary = value;
            }
        }
    }
}
