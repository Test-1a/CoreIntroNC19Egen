using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreIntroNC19Egen.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreIntroNC19Egen.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index(int salary, string name)
        {
            //return $"Demo Index id:{id}";
            //return HtmlEncoder.Default.Encode($"Demo index id:{id} name {name}");

            //ViewData["id"] = id;
            //ViewData ["name"] = name;

            var model = new Person()
            {
                Name = name,
                Salary = salary
            };

            return View(model);
        }
    }
}