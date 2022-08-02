using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models.ViewModels
{
    public class RecipeListViewModel
    {
        public IEnumerable<Recipe> Recipes { get; set; }
    }
}
