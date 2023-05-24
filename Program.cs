using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace worl_3
{
    class Program
    {
        static void Main(string[] args)
        {
        Employee employee1 = new Employee();
            employee1.Fullname = "Косых Иван Андреевич";
            employee1.Department = 1;
            employee1.Salary = 500000;
            Employee employee2 = new Employee();
        employee2.Fullname = "Комочкоч Денис Александрович";
            employee2.Department = 2;
            employee2.Salary = 20000;
            Console.WriteLine("Сотрудник 1 (id {0}) : {1}, отдел {2}, зарплата {3}", employee1.id, employee1.Fullname, employee1.Department, employee1.Salary);
            Console.WriteLine("Сотрудник 2 (id {0}): {1}, отдел {2}, зарплата{3}", employee2.id, employee2.Fullname, employee2.Department, employee2.Salary);
           Console.ReadKey();
    }

}
    }
