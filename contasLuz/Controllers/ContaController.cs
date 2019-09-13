using contasLuz.Models;
using Microsoft.AspNetCore.Mvc;


namespace contasLuz.Controllers
{
    public class ContaController : Controller
    {
        ContaRepository _repository = 
            new ContaRepository();
        public IActionResult Index()
        {
            var contas = _repository.GetAllContaLuz();
            return View(contas);
        }
        
        public IActionResult Create()
        {            
            return View();
        }

        [HttpPost]
        public RedirectToActionResult Create(Conta conta)
        {            
            _repository.Create(conta);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {   
            
            return View(_repository.GetById(id));
        }

        [HttpPost]
        public RedirectToActionResult Edit(Conta conta)
        {            
            _repository.Update(conta);
            return RedirectToAction("Index");
        }


        public IActionResult Delete(int id)
        {   
            _repository.Delete(id);
            return RedirectToAction("Index");
        }
        
    }
}