using contasLuz.Models;
using Microsoft.AspNetCore.Mvc;


namespace contasLuz.Controllers
{
    public class ContaController : Controller
    {
        private IContaRepository _repository;

        public ContaController(IContaRepository repository){
        this._repository = repository;
        }

        public IActionResult Index()
        {
            var listConta = _repository.GetAll();
            return View(listConta);
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
            var conta = _repository.GetById(id);
            return View(conta);
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