using Lab.EF.Data;
using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class EmployeesLogic : BaseLogic, IABMLogic<Employees>
    {
        public void Add(Employees newEmployee)
        {
            context.Employees.Add(newEmployee);
            context.SaveChanges();
        }


        public void Delete(int id)
        {
            var employeesAEliminiar = context.Employees.Find(id);

            context.Employees.Remove(employeesAEliminiar);
            context.SaveChanges();
        }

        public List<Employees> GetAll()
        {
            return context.Employees.ToList(); 
        }

        public void Update(Employees update)
        {
            throw new NotImplementedException();
        }
    }
}
