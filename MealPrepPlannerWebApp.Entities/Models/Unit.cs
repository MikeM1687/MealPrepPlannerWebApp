using System;
using System.Collections.Generic;

namespace MealPrepPlannerWebApp.Entities.Models
{
    public partial class Unit : BaseEntity
    {
        public Unit()
        {
            Ingredient = new HashSet<Ingredient>();
        }

        //public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Ingredient> Ingredient { get; set; }
    }
}
