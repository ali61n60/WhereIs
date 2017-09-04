using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WhereIs.Controllers
{
    public class HomeController:Controller
    {
        public ViewResult Index()
        {
            int a = 10;
            int b = 0;
            double c = a / b;
            return View();
        }
    }
}
