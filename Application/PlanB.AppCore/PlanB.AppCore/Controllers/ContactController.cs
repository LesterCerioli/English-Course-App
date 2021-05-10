using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanB.AppCore.Controllers
{
    public class ContactController : Controller

    {
        public IActionResult Index()
        {
            return View();
        }
    }
}