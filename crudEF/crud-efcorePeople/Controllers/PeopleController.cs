using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using crud_efcorePeople.Models;

namespace crud_efcorePeople.Controllers
{
    public class PeopleController : Controller
    {
        private IPersonRepository repository;
        public PeopleController(IPersonRepository repository){
            this.repository = repository;
        }
        public IActionResult Index()
        {
            var listPeople = repository.GetAll();
            return View(listPeople);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
          public IActionResult Create(Person person)
        {
            repository.Create(person);
            return RedirectToAction("Index");
        }
        
        public IActionResult Edit(int id)
        {
            var person = repository.GetById(id);
            return View(person);
        } 

        [HttpPost]
          public IActionResult Edit(Person person)
        {
            repository.Update(person);
            return RedirectToAction("Index");
        }

          public IActionResult Delete(int id)
        {
            repository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
