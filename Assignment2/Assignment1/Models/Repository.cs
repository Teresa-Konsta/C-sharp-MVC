using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class Repository
    {
        private static List<Recipe> recipes = new List<Recipe>();

        public static List<Recipe> Recipes
        {
            get
            {
                return recipes;
            }
        }

        public static void AddRecipe(Recipe recipe)
        {
            recipes.Add(recipe);
        }

        public static List<Recipe> recipeReviews = new List<Recipe>();

        public static void AddRecipeReviw(Recipe review)
        {
            recipeReviews.Add(review);
        }
    }
}
