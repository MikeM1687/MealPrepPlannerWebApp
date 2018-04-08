using MealPrepPlannerWebApp.Entities.Models;
using MealPrepPlannerWebApp.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MealPrepPlannerWebApp.Services.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Meal> MealRepository { get; }
        IRepository<Ingredient> IngredientRepository { get; }
    }
}
