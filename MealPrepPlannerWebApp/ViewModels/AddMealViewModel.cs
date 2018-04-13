using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealPrepPlannerWebApp.ViewModels
{
    public class AddMealViewModel
    {
        public string Name { get; set; }
        public List<IngredientViewModel> Ingredients { get; set; } 
    }
}
