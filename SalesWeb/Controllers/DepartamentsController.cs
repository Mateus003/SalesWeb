using Microsoft.AspNetCore.Mvc;
using SalesWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWeb.Controllers
{
    public class DepartamentsController : Controller
    {

        public IActionResult Index()
        {
            List<Departament> departaments = new List<Departament>();

            departaments.Add(new Departament(1, "Eletronics"));
            departaments.Add(new Departament(1, "Fashion"));

            return View(departaments);
        }
    }
}
