using MealPrepPlannerWebApp.Entities.Models;
using MealPrepPlannerWebApp.Services;
using MealPrepPlannerWebApp.Services.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MealPrepPlannerWebApp.Tests.Service.Tests
{
    public class DataServiceTests
    {
        private List<Meal> MealsTestData()
        {
            return new List<Meal>
            {
                new Meal { Id = 1, Name = "Meal 1", IngredientId = 1},
                new Meal { Id = 2, Name = "Meal 2", IngredientId = 1}
            };
        }

        private List<Ingredient> IngredientsTestData()
        {
            return new List<Ingredient>
            {
                new Ingredient { Id = 1, Name = "Ingredient 1", UnitId = 2},
                new Ingredient { Id = 2, Name = "Ingredient 2", UnitId = 2},
                new Ingredient { Id = 3, Name = "Ingredient 3", UnitId = 1},
            };
        }

        private List<Unit> UnitsTestData()
        {
            return new List<Unit>
            {
                new Unit {Id = 1, Name = "ml"},
                new Unit {Id = 2, Name = "g"}
            };
        }

        [Fact]
        public void GetAllMeals_Returns_AllMeals()
        {
            var mockUnitOfWork = new Mock<IUnitOfWork>();
            mockUnitOfWork.Setup(x => x.MealRepository.GetAll())
                .Returns(MealsTestData());

            var dataService = new DataService(mockUnitOfWork.Object);

            var meals = dataService.GetMeals();

            Assert.Equal(MealsTestData().Count, meals.Count);
        }

        [Fact]
        public void GetAllIngredients_Returns_AllIngredients()
        {
            var mockUnitOfWork = new Mock<IUnitOfWork>();
            mockUnitOfWork.Setup(x => x.IngredientRepository.GetAll())
                .Returns(IngredientsTestData());

            var dataService = new DataService(mockUnitOfWork.Object);

            var ingredients = dataService.GetIngredients();

            Assert.Equal(IngredientsTestData().Count, ingredients.Count);
        }

        [Fact]
        public void GetAllUnits_Returns_AllUnits()
        {
            var mockUnitOfWork = new Mock<IUnitOfWork>();
            mockUnitOfWork.Setup(x => x.UnitRepository.GetAll())
                .Returns(UnitsTestData());

            var dataService = new DataService(mockUnitOfWork.Object);

            var units = dataService.GetUnits();

            Assert.Equal(UnitsTestData().Count, units.Count);
        }
    }
}
