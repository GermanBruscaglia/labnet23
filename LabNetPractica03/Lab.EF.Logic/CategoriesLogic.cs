using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class CategoriesLogic : BaseLogic, IABMLogic<Categories>
    {
        public void Add(Categories add)
        {
            context.Categories.Add(add);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            Categories categoriaDelete = context.Categories.Find(id);
            //context.Categories.Remove(context.Categories.Find(id));
            context.Categories.Remove(categoriaDelete);
            
            context.SaveChanges();
        }

        public List<Categories> GetAll()
        {
            return context.Categories.ToList();
        }

        public Categories GetByID(int id)
        {
            return context.Categories.Find(id);
        }

        public void Update(Categories update)
        {
            Categories categoriaUpdate = context.Categories.Find(update.CategoryID);

            categoriaUpdate.CategoryName = update.CategoryName;
            categoriaUpdate.Description = update.Description;

            context.SaveChanges();
        }
    }
}
