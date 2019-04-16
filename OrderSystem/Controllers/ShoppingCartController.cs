using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrderSystem.Models;

namespace OrderSystem.Controllers
{
    public class ShoppingCartController : Controller
    {
        OrderingSystemContext _context;

        [HttpGet]
        public IActionResult ShoppingCart()
        {
            return View();
        }


    }
}