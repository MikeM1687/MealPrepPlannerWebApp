using MealPrepPlannerWebApp.Controllers;
using MealPrepPlannerWebApp.Entities.Models;
using MealPrepPlannerWebApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MealPrepPlannerWebApp.Tests.Controller.Tests
{
    public class FoodControllerTests
    {
        private List<Meal> MealsTestData()
        {
            return new List<Meal>
            {
                new Meal {Id = 1, Name = "Meal 1"},
                new Meal {Id = 2, Name = "Meal 2"},
                new Meal {Id = 3, Name = "Meal 3"},
            };
        }

        [Fact]
        public void FoodIndex_GetsListOfAllMeals_ReturnsAllMeals()
        {
            var mockDataService = new Mock<IDataService>();
            mockDataService.Setup(x => x.GetMeals())
                .Returns(MealsTestData());

            var controller = new FoodController(mockDataService.Object);

            var result = controller.Index();

            ViewResult viewResult = Assert.IsType<ViewResult>(result);

            var viewModel = Assert.IsType<FoodViewModel>(viewResult.Model);

            Assert.Equal(MealsTestData().Count, viewModel.Meals.Meal.Count);            
        }
    }
}
