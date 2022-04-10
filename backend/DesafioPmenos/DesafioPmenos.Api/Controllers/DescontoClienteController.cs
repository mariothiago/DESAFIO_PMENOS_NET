using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPmenos.Api.Controllers
{
    public class DescontoProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
