using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Repositories;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using TESTE.Repositories;

namespace LPC_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImovelController : ControllerBase
    {
        private ImovelRepository _repo;
        public ImovelController(ImovelRepository repository){
        
            _repo = repository;
        }
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_repo.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_repo.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult<string> Post([FromBody] Imovel value)
        {
            return Ok(_repo.Insert(value));
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult<string> Put(int id, [FromBody] Imovel value)
        {
            return Ok(_repo.Update(value));
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult<string> Delete(int id)
        {
            return Ok(_repo.Delete(id));
        }
    }
}