using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreGitDeployemt.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            string str = "Room";
            return View();
        }
    }
}
