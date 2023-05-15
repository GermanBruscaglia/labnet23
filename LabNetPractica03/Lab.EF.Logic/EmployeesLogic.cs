using Lab.EF.Data;
using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class EmployeesLogic : BaseLogic
    {

        public List<Employees> GetAll()
        {
            return _nortwindContext.Employees.ToList(); 
        }
    }
}
