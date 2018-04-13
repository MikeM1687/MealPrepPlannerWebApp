using MealPrepPlannerWebApp.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MealPrepPlannerWebApp.Services.Interfaces
{
    public interface IDataService
    {
        List<Meal> GetMeals();
        List<Ingredient> GetIngredients();
        List<Unit> GetUnits();
    }
}
