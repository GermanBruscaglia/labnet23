using Lab.EF.Entities;
using Lab.EF.Logic;
using Lab.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json.Linq;
using System.Text;

namespace Lab.WebApi.Controllers
{
    public class ValuesController : ApiController
    {
        CategoriesLogic Logic = new CategoriesLogic();
        // GET api/values
        public List<CategorieModel> Get()
        {
            List<Categories> allCategories = Logic.GetAll();

            List<CategorieModel> categorieList = allCategories.Select(c => new CategorieModel
            {
                Name = c.CategoryName,
                Descripcion = c.Description,
                Id = c.CategoryID
            }).ToList();

            return categorieList;
        }

        // GET api/values/5
        public CategorieModel Get(int id)
        {
            Categories categoriePorID = Logic.GetByID(id);
     
             CategorieModel objID = new CategorieModel
            {
                Id = categoriePorID.CategoryID,
                Name = categoriePorID.CategoryName,
                Descripcion = categoriePorID.Description
            };
            return objID;
        }

        // POST api/values
        public void Post([FromBody] CategorieModel value)
        {

            Categories categoriaNueva = new Categories 
            { 
                CategoryName = value.Name, 
                Description = value.Descripcion 
            };
            Logic.Add(categoriaNueva);

        }

        // PUT api/values/5
        public void Put(int id, [FromBody] CategorieModel value)
        {
            Categories categorieUpdate = new Categories
            {
                CategoryID = id,
                CategoryName = value.Name,
                Description = value.Descripcion
            };
            Logic.Update(categorieUpdate);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
                Logic.Delete(id);
        }
    }
}
