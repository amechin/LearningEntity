using LearnEntityByCodeFirst.Entities.CodeFirst;
using LearnEntityByCodeFirst.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEntityByCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> lEmp = new List<Employee>();
            var eRep = new EmployeeRepository();
            var dRep = new DepartmentRepository();

            var dep = new Department();
            dep = dRep.FindById(2);
            
            //Méthode findAll
            lEmp = eRep.FindAll();
            foreach (Employee emp in lEmp)
            {
                Console.WriteLine(emp.Firstname.ToString());
            }

            //Méthode Add
            var _emp = new Employee()
            {
                Firstname = "Damien",
                LastName = "Bonnefoy",
                Gender = "Male",
                Salary = 2454,
                Department = dep
            };
            _emp = eRep.AddEmployee(_emp);
            Console.WriteLine(_emp.Id);
        }
    }
}
