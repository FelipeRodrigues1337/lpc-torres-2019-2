using Microsoft.AspNetCore.Mvc;
using ToDoList.classes;
using ToDoList.interfaces;


namespace ToDoList.MVC.Controllers
{
    public class ImovelController : Controller
    {
        private IImovelRepository _repository;

        public ImovelController(IImovelRepository repository){
        this._repository = repository;
        }

        public IActionResult Index()
        {
            var listImoveis = _repository.GetAll();
            return View(listImoveis);
        }
  
        public IActionResult Create()
        {            
            return View();
        }

        [HttpPost]
        public RedirectToActionResult Create(Imoveis Imoveis)
        {            
            _repository.Create(Imoveis);
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {   
            var Imoveis = _repository.GetById(id);
            return View(Imoveis);
        }

        [HttpPost]
        public RedirectToActionResult Update(Imoveis Imoveis)
        {            
            _repository.Update(Imoveis);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {   
            _repository.Delete(id);
         return RedirectToAction("Index");
        }
    }
}