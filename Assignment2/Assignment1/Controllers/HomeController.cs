using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment1.Models;
using Assignment1.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    public class HomeController : Controller
    {             
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult RecipeList()
        {
            return View(Repository.Recipes.OrderBy(r => r.RecipeName).ToList<Recipe>());
        }

        [HttpGet]
        public ViewResult ViewRecipe(Recipe recipeId)
        {
            return View(Repository.Recipes.OrderBy(r => r.RecipeID).ToList<Recipe>());
        }

        [HttpPost]
        public ViewResult ReviewRecipe(Recipe review)
        {
            if (ModelState.IsValid)
            {
                Repository.AddRecipeReviw(review);
                return View();
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public ViewResult ReviewRecipe()
        {
            return View();
        }

        [HttpPost]
        public ViewResult AddRecipe(Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                Repository.AddRecipe(recipe);
                return View("RecipeSummary", recipe);
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public ViewResult AddRecipe()
        {
            return View();
        }

        [HttpGet]
        public ViewResult RecipeSummary()
        {
            return View();
        }
    }
}
