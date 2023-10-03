using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class CarroController : Controller
    {
        
        public ActionResult Index()
        {
            var carro = CarroModel.CriarLista();
            return View(carro);
        }

        public ActionResult Details(int id)
        {
            var carro = CarroModel.CriarLista()[id];
            return View(carro);
        }

       
        public ActionResult Create(int id)
        {
            var carro = CarroModel.CriarLista()[id];
            return View(carro);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
         

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        
        public ActionResult Edit(int id)
        {
            var carro = CarroModel.CriarLista()[id];
            return View(carro);
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

      
        public ActionResult Delete(int id)
        {
            var carro = CarroModel.CriarLista()[id];
            return View(carro);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
              
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}