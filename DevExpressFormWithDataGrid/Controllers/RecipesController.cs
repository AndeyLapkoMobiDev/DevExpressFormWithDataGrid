using System.Collections.Generic;
using DevExpressFormWithDataGrid.Models;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace DevExpressFormWithDataGrid.Controllers
{
    [Route("api/[controller]/[action]")]
    public class RecipesController : Controller
    {
        private List<Recipe> _recipes;

        public RecipesController()
        {
            _recipes = new List<Recipe>()
            {
                new Recipe()
                {
                    Id = 1, Name = "recipe1",
                    Description = @"
Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. 
Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. 
Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. 
Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                    RecipeIngredients = new List<RecipeIngredient>()
                    {
                    new RecipeIngredient(){RecipeId = 1, IngredientId = 1
                },
                new RecipeIngredient() {RecipeId = 1, IngredientId = 2},
            }
            },
            new Recipe()
            {
                Id = 2, Name = "recipe2",
                Description = "",
                RecipeIngredients = new List<RecipeIngredient>()
                {
                    new RecipeIngredient() {RecipeId = 2, IngredientId = 2},
                    new RecipeIngredient() {RecipeId = 2, IngredientId = 3},
                }
            }
            };
        }

        [HttpGet]
        public object Recipes(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(_recipes, loadOptions);
        }
    }
}