using Lab.EF.Entities;
using Lab.EF.Logic;
using Lab.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.MVC.Controllers
{
    public class CategoriesController : Controller
    {
        CategoriesLogic Logic = new CategoriesLogic();
        
        public ActionResult Index()
        {

            List<Categories> allCategories = Logic.GetAll();

            List<CategoriesModel> categoriesView = allCategories.Select(c => new CategoriesModel
            {
                Id = c.CategoryID,
                Name = c.CategoryName,
                Descripcion = c.Description
                
            }).ToList();

            return View(categoriesView);
        }

        public ActionResult insert()
        {
            return View();
        }
        [HttpPost]
        public ActionResult insert(CategoriesModel categorietModel)
        {
            try
            {
                var categorieEntity = new Categories { CategoryName = categorietModel.Name, Description = categorietModel.Descripcion };
                Logic.Add(categorieEntity);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }
        }
        public ActionResult Delete(int id)
        {
            Logic.Delete(id);

            return RedirectToAction("index", "Categories");
        }

        public ActionResult Update(CategoriesModel categorieModel)
        {
            try
            {
                Logic.Update(new Categories
                {
                    CategoryName = categorieModel.Name,
                    CategoryID = categorieModel.Id,
                    Description = categorieModel.Descripcion
                });
                return RedirectToAction("Index");

            }

            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }

        }
    }
}