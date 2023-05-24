using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace worl_3
{
    class Employee
    {
        private static int idCounter = 0;
        public int id { get; private set; }
        public string Fullname { get; set; }
        public int Department { get; set; }
        public double Salary { get; set; }
        public Employee()
        {
            id = ++idCounter;
        }
    }
}