using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MealPrepPlannerWebApp.Services.Interfaces;
using MealPrepPlannerWebApp.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MealPrepPlannerWebApp.Controllers
{
    public class FoodController : Controller
    {
        private readonly IDataService _dataService;

        public FoodController(IDataService dataService)
        {
            _dataService = dataService;
        }

        // GET: Food
        public ActionResult Index()
        {
            var model = new FoodViewModel();

            var meals = _dataService.GetMeals().ToList();

            model.Meals = new MealViewModel();

            var mealsList = model.Meals.Meal = new List<MealRowViewModel>();

            foreach (var meal in meals)
            {
                mealsList.Add(new MealRowViewModel
                {
                    Name = meal.Name
                });
            }

            return View(model);
        }

        // GET: Food/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Food/Create
        public ActionResult AddMeal()
        {
            //var viewModel = new AddMealViewModel();

            return View();
        }

        // POST: Food/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public IActionResult AddIngredient(IngredientViewModel viewModel)
        {
            var units = _dataService.GetUnits();

            var unitsList = viewModel.Units = new List<SelectListItem>();

            foreach (var unit in units)
            {
                unitsList.Add(new SelectListItem { Text = unit.Name, Value = unit.Id.ToString()});
            }

            return View(viewModel);
        }

        // GET: Food/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Food/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Food/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Food/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}