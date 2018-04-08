using MealPrepPlannerWebApp.Entities.Models;
using MealPrepPlannerWebApp.Repositories.Interfaces;
using MealPrepPlannerWebApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MealPrepPlannerWebApp.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private MealPrepPlannerWebApp_DatabaseContext _context { get; }

        public IRepository<Meal> MealRepository { get; }
        public IRepository<Ingredient> IngredientRepository { get; }

        public UnitOfWork(MealPrepPlannerWebApp_DatabaseContext context,
            IRepository<Meal> mealRepository,
            IRepository<Ingredient> ingredientRepository)
        {
            _context = context;
            MealRepository = mealRepository;
            IngredientRepository = ingredientRepository;
        }
    }
}
