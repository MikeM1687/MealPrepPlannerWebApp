using MealPrepPlannerWebApp.Entities.Models;
using MealPrepPlannerWebApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MealPrepPlannerWebApp.Services
{
    public class DataService : IDataService
    {
        private readonly IUnitOfWork _unitOfWork;

        public DataService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        #region Meals
        public List<Meal> GetMeals()
        {
            return _unitOfWork.MealRepository.GetAll().ToList();
        }
        #endregion

        #region Ingredients
        public List<Ingredient> GetIngredients()
        {
            return _unitOfWork.IngredientRepository.GetAll().ToList();
        }

        public void CreateIngredient(Ingredient ingredient)
        {
            _unitOfWork.IngredientRepository.Add(ingredient);
        }

        #endregion

        #region Units
        public List<Unit> GetUnits()
        {
            return _unitOfWork.UnitRepository.GetAll().ToList();
        }

        #endregion

    }
}
