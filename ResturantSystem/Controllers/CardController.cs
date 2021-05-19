using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ResturantSystem.Models;
using Microsoft.AspNetCore.Mvc;


namespace ResturantSystem.Controllers
{
    public class CardController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult SubmitForm(Card card)
        {
            if (string.IsNullOrEmpty(card.Name))
            {
                ModelState.AddModelError(nameof(card.Name), "Please enter your name!");
            }
            if (string.IsNullOrEmpty(card.Surname))
            {
                ModelState.AddModelError(nameof(card.Surname), "Please enter your surname!");
            }
            if (string.IsNullOrEmpty(card.PhoneNumber))
            {
                ModelState.AddModelError(nameof(card.PhoneNumber), "Please enter your phone number!");
            }
            if (ModelState.IsValid)
            {
                return RedirectToAction("Details", card);
            }
            return View("Create");
        }

        public IActionResult Details(Card card)
        {
            return View(card);
        }
        public IActionResult Charge()
        {
            return View();
        }

        public IActionResult SubmitCharge(string id , int balance)
        {
            Card card = new Card();
            if (string.IsNullOrEmpty(id))
            {
                ModelState.AddModelError(nameof(id), "Please enter your card id!");
            }
            if (ModelState.IsValid)
            {
                return View("Details", card);
            }
            return View("Charge");
        }
    }
}
