using System.Collections.Generic;
using DevExpressFormWithDataGrid.Models;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace DevExpressFormWithDataGrid.Controllers
{
    [Route("api/[controller]/[action]")]
    public class IngredientsController : Controller
    {
        private List<Ingredient> _ingredients { get; set; }

        public IngredientsController()
        {
            _ingredients = new List<Ingredient>()
            {
                new Ingredient(){Id = 1, Name = "ingredient1"},
                new Ingredient(){Id = 2, Name = "ingredient2"},
                new Ingredient(){Id = 3, Name = "ingredient3"},
            };
        }
        
        [HttpGet]
        public object Ingredients(DataSourceLoadOptions loadOptions)
        {
            return DataSourceLoader.Load(_ingredients, loadOptions);
        }
    }
}