using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using Microsoft.AspNetCore.Mvc;
using api.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace api.Controllers
{
    [Route("api/container")]
    [ApiController]
    public class ContainerController : ControllerBase    {
        private readonly ApplicationDBContext _context;
        public ContainerController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllContainers()
        {
            var containers = _context.Containers.ToList();
            return Ok(containers);
        }

        [HttpGet("{id}")]
        public IActionResult GetContainerById(int id){
            var container = _context.Containers.Find(id);

            if(container == null){
                return NotFound();
            }

            return Ok(container);
        }

        [HttpPost]
        public IActionResult AddContainer([FromBody] api.Models.Container newContainer){
            if(newContainer == null)
            {
                return BadRequest("Invalid container data");
            }
            _context.Containers.Add(newContainer);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetContainerById), new { id = newContainer.Id}, newContainer);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateContainer(int id, [FromBody] api.Models.Container updatedContainer)
       {
        var container = _context.Containers.Find(id);

        if(container == null){
            return NotFound();
        }
        
        container.Number = updatedContainer.Number;
        container.Type = updatedContainer.Type;
        container.Length = updatedContainer.Length;
        container.Width = updatedContainer.Width;
        container.Height = updatedContainer.Height;
        container.Weight = updatedContainer.Weight;
        container.IsEmpty = updatedContainer.IsEmpty;
        container.ArivingDate = updatedContainer.ArivingDate;

        _context.Containers.Update(container);
        _context.SaveChanges();

        return NoContent();
       }

       [HttpDelete("{id}")]
       public IActionResult DeleteContainer(int id)
       {
        var container = _context.Containers.Find(id);

        if(container == null){
            return NotFound();
        }

        _context.Containers.Remove(container);
        _context.SaveChanges();

        return NoContent();
       }
        
    }
}