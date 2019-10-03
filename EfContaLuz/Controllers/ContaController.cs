using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EfContaLuz.Models;

namespace EfContaLuz.Controllers
{
    public class ContaController : Controller
    {
         
        private IContaRepository repository;
        public ContaController(IContaRepository repository)
        {
            this.repository = repository;
        }
        public IActionResult Index()
        {      
            return View(new ContaView(repository));
          
        }

        public IActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
         public IActionResult Create(Conta c)
        {
           repository.Create(c);
            return RedirectToAction("Index");
        }

         public IActionResult Edit(int id)
        {
            var conta = repository.GetById(id);
            return View(conta);
        }

        [HttpPost]
         public IActionResult Edit(Conta c)
        {
           repository.Update(c);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            repository.Delete(id);
            return RedirectToAction("Index");

        }

       
       
    }
}