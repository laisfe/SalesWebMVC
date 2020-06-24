﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;
using SalesWebMVC.Services;

//O controlador recebeu a chamada do localhost/Sellers
namespace SalesWebMVC.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }

        //Aciona a ação Index que retorna a View.
        //A View irá até a pasta Views, procura-rá a pasta dentro 
        //dela que tem o mesmo nome da controller atrás de um arquivo chamado Index
        public IActionResult Index()
        {
            //retorna uma lista de seller
            var list = _sellerService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {
            _sellerService.Insert(seller);
            
            //Depois da inserção, redireciona a aplicação para a página Index para mostrar novamente a lista de vendedores
            return RedirectToAction(nameof(Index));
        }
    }
}