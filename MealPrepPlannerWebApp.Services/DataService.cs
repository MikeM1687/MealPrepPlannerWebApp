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

        public List<Meal> GetMeals()
        {
            return _unitOfWork.MealRepository.GetAll().ToList();
        }

        public List<Ingredient> GetIngredients()
        {
            return _unitOfWork.IngredientRepository.GetAll().ToList();
        }

        public List<Unit> GetUnits()
        {
            return _unitOfWork.UnitRepository.GetAll().ToList();
        }
    }
}
