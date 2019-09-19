using LearnEntityByCodeFirst.Entities.CodeFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnEntityByCodeFirst.Repository
{
    class DepartmentRepository
    {
        public List<Department> FindAll()
        {
            using (var context = new SMContext())
            {
                return context.Department.OrderByDescending(x => x.Id).ToList();
            }
        }

        public Department FindById(int _id)
        {
            using (var context = new SMContext())
            {
                return context.Department.FirstOrDefault(x => (x.Id == _id));
            }
        }

        public Department AddDepartment(Department _dep)
        {
            using (var context = new SMContext())
            {
                context.Department.Add(_dep);
                context.SaveChanges();

                return context.Department.FirstOrDefault(
                    x => (x.Name.ToLower() == _dep.Name.ToLower()));
            }
        }
        
        public Department UpdateDepartment(int _id, Department _dep)
        {
            using (var context = new SMContext())
            {
                var tDep = context.Department.FirstOrDefault(x => (x.Id == _id));
                tDep = _dep;
                tDep.Id = _id;
                context.Department.Add(tDep);
                context.SaveChanges();

                return context.Department.FirstOrDefault(x => (x.Name.ToLower() == _dep.Name.ToLower()));
            }
        }

        public void RemoveDepartment(int _id)
        {
            using (var context = new SMContext())
            {
                Department dpt = context.Department.FirstOrDefault(x => (x.Id == _id));
                if (dpt != null)
                {
                    context.Department.Remove(dpt);
                    context.SaveChanges();
                }
            }
        }
    }
}
