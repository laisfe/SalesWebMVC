using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

//O controlador recebeu a chamada do localhost/Sellers
namespace SalesWebMVC.Controllers
{
    public class SellersController : Controller
    {
        //Aciona a ação Index que retorna a View.
        //A View irá até a pasta Views, procura-rá a pasta dentro 
        //dela que tem o mesmo nome da controller atrás de um arquivo chamado Index
        public IActionResult Index()
        {
            return View();
        }
    }
}