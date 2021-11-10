using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Phase4Assesment.Models;

namespace Phase4Assesment.Controllers
{
    public class PizzaController : Controller
    {
       
        private static readonly PizzaBO context = new PizzaBO();
        private static List<PizzaModel> pizzas = context.GetItems();

        public IActionResult Index()
        {
            return View(pizzas);
        }
        public IActionResult Details(int id)
        {
            return View(context.GetItemById(id));
        }
        public IActionResult Order(int id)
        {
            return View(context.GetItemById(id));
        }

       
    }
}
