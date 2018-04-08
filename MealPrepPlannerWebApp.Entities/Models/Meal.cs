using System;
using System.Collections.Generic;

namespace MealPrepPlannerWebApp.Entities.Models
{
    public partial class Meal : BaseEntity
    {
        //public int Id { get; set; }
        public string Name { get; set; }
        public int IngredientId { get; set; }

        public Ingredient Ingredient { get; set; }
    }
}
