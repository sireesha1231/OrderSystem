using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderSystem.Models;


namespace OrderSystem.Controllers
{
    public class ProductController : Controller
    {

        OrderingSystemContext _context;

        public ProductController(OrderingSystemContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult Category()
        {
            var categories = _context.Category_Detail.ToList();
            ViewData["categories"] = categories;

            return View();
        }


        [HttpGet]
        public IActionResult SubCategory(int id)
        {
            var subcategories = _context.Sub_Category_Details.Where(x => x.Category_ID == id).ToList();
            ViewData["subcategories"] = subcategories;

            return View();
        }

        [HttpGet]
        public IActionResult Products(int id)
        {
            var products = _context.Product_Details.Where(x => x.Sub_Category_ID == id).ToList();
            ViewData["products"] = products;

            return View();
        }





        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
