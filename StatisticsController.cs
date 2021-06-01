using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ResturantSystem.Models;

namespace ResturantSystem.Controllers
{
    public class StatisticsController : Controller
    {
       
        public IActionResult Create()
        {
            return View();

        }
        public IActionResult FavoriteFood(int Position_Id, char Gender, //en cok sevilen yemek ogrenciler, akdemisyenler, persiyonaller
            int User_Id, DateTime FoodOperationDate, int Meal_Id, string MealName){
            return View();
        }
        public IActionResult FavoriteFood(int Position_Id, //genel sevilen yemek
            int User_Id, DateTime FoodOperationDate, int Meal_Id, string MealName)
        {
            return View();
        }
        public IActionResult MostEatenGroup(int Position_Id, //en fazla yemek yiyen grup ogrenciler mi akdemisyenler mi aylik haftalik yillik 
            int User_Id, DateTime FoodOperationDate)
        {
            return View();
        }
        public IActionResult MostEatenGender(int Position_Id, //en fazla yemek yiyen Cinsiyet aylik haftalik yillik 
          int User_Id, char Gender, DateTime FoodOperationDate)
        {
            return View();
        }
        public IActionResult BirthDayMeal(int Position_Id, // Bir ayda dogum gununu olan kisinin yemek ismarlamak 
         int User_Id, DateTime BirthOfDate)
        { //output  string MealName  dondurur
            return View();
        }

        public IActionResult AvreageAge(int Position_Id, //ogrenci akdemisyan personallarin yas ortalamalari
         int User_Id, DateTime BirthOfDate)
        { 
            return View();
        }



    }
}
