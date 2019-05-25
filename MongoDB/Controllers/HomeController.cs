using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Models;
using MongoDB.SamleData;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Services;

namespace MongoDB.Controllers
{
    
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            //using statement is useful for objects whose lifetimes are
            //within the method or block in which they are created = Smart to use here
            try
            {
                using (DataAccess dataAcess = new DataAccess())
                {
                    var users = dataAcess.GetMongoCollection<User>("User");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
