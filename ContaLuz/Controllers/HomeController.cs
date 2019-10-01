using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ContaLuz.Models;

namespace ContaLuz.Controllers
{
    public class HomeController : Controller
    {

        HomeRepository _repository =
        new HomeRepository();
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult Conta()
        {     
            ViewData["Message"]= "Lista de contas";
            // var conta = _repository.GetAll();  
            return View(new HomeViewModel(_repository));
        }
       public IActionResult Create()
       {
           return View();
       }
       [HttpPost]
        public RedirectToActionResult Create(Home conta)
        {            
            _repository.Create(conta);
            return RedirectToAction("Conta");
        }


       public IActionResult Edit(int id)
       {
           return View(_repository.GetById(id));
       }
       [HttpPost]
        public RedirectToActionResult Edit(Home conta)
        {            
            _repository.Update(conta);
            return RedirectToAction("Index");
        }

       public IActionResult Delete(int id)
       {
           _repository.Delete(id);
           return RedirectToAction("Index");
       }
       public IActionResult Consumo()
       {   
           return View(new HomeViewModel(_repository));
       }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
