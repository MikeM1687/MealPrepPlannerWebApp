using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealPrepPlannerWebApp.ViewModels
{
    public class IngredientViewModel
    {
        public string Name { get; set; }
        public decimal Quantity { get; set; }
        public List<SelectListItem> Units { get; set; }
        public int UnitId { get; set; }
    }
}
