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
        private ImovelRepository _respo;
        public ImovelController(ImovelRepository repository){
        
            _respo = repository;
        }
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_respo.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_respo.GetById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult<string> Post([FromBody] Imovel value)
        {
            return Ok(_respo.Insert(value));
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult<string> Put(int id, [FromBody] Imovel value)
        {
            return Ok(_respo.Update(value));
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult<string> Delete(int id)
        {
            return Ok(_respo.Delete(id));
        }
    }
}