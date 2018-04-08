using System;
using System.Collections.Generic;

namespace MealPrepPlannerWebApp.Entities.Models
{
    public partial class Ingredient : BaseEntity
    {
        public Ingredient()
        {
            Meal = new HashSet<Meal>();
        }

        //public int Id { get; set; }
        public string Name { get; set; }
        public decimal Qty { get; set; }
        public int UnitId { get; set; }

        public Unit Unit { get; set; }
        public ICollection<Meal> Meal { get; set; }
    }
}
