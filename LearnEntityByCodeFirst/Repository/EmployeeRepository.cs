using LearnEntityByCodeFirst.Entities.CodeFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEntityByCodeFirst.Repository
{
    public class EmployeeRepository
    {
        public List<Employee> FindAll()
        {
            using (var context = new SMContext())
            {
                return context.Employee.OrderByDescending(x => x.Id).ToList();
            }
        }

        public Employee FindById(int _id)
        {
            using (var context = new SMContext())
            {
                 return context.Employee.FirstOrDefault(x => (x.Id == _id));
            }
        }

        public Employee AddEmployee(Employee _emp)
        {
            using (var context = new SMContext())
            {
                context.Employee.Add(_emp);
                context.SaveChanges();

                return context.Employee.FirstOrDefault(
                    x => (x.Firstname.ToLower() == _emp.Firstname.ToLower()
                        && x.LastName.ToLower() == _emp.LastName.ToLower()
                        ));
            }
        }

        public Employee UpdateEmployee(int _id, Employee _emp)
        {
            using (var context = new SMContext())
            {
                var tEmp = context.Employee.FirstOrDefault(x => (x.Id == _id));
                tEmp = _emp;
                tEmp.Id = _id;
                context.Employee.Add(tEmp);
                context.SaveChanges();

                return context.Employee.FirstOrDefault(
                    x => (x.Firstname.ToLower() == _emp.Firstname.ToLower()
                        && x.LastName.ToLower() == _emp.LastName.ToLower()
                        ));
            }
        }

        public void RemoveEmployee(int _id)
        {
            using (var context = new SMContext())
            {
                Employee tEmp = context.Employee.FirstOrDefault(x => (x.Id == _id));
                if(tEmp != null)
                {
                    context.Employee.Remove(tEmp);
                    context.SaveChanges();
                }
            }
        }
    }
}
