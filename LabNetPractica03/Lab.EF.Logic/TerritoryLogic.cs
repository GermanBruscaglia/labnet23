using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class TerritoryLogic : BaseLogic, IABMLogic<Territories>
    {
        public void Add(Territories add)
        {
                context.Territories.Add(add);
                context.SaveChanges();
        }

        public void Delete(int id)
        {
            Territories territorioDelete = context.Territories.Find(id);

            context.Territories.Remove(territorioDelete);
            context.SaveChanges();
        }

        public List<Territories> GetAll()
        {
            return context.Territories.ToList();
        }

        public void Update(Territories update)
        {
            Territories territorioUpdate = context.Territories.Find(update.TerritoryID);

            update.TerritoryDescription = update.TerritoryDescription;

            context.SaveChanges();
        }
    }
}
