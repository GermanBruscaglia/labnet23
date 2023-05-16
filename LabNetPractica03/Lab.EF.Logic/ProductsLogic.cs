using Lab.EF.Data;
using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class ProductsLogic : BaseLogic, IABMLogic<Products>
    {
        public void Add(Products add)
        {
            context.Products.Add(add);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            Products productoAEliminar = context.Products.Find(id);
            context.Products.Remove(productoAEliminar);
            context.SaveChanges();
        }

        public List<Products> GetAll()
        {
            return context.Products.ToList();
        }

        public void Update(Products update)
        {
            Products productUpdate = context.Products.Find(update.ProductID);

            productUpdate.ProductName = update.ProductName;

            context.SaveChanges();
        }

    }
}
