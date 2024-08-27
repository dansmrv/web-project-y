using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using Microsoft.AspNetCore.Mvc;
using api.Models;

namespace api.Controllers
{
    public class OperationController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public OperationController(ApplicationDBContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public IActionResult GetAllOperations()
        {
            //Берем из бд
            var operations = _context.Operations.ToList();
            return Ok(operations);
        }

        [HttpGet("{id}")]
        public IActionResult GetOperationsById([FromRoute] int id)
        {
            var operation = _context.Operations.Find(id);

            if (operation == null)
            {
                return NotFound();
            }

            return Ok(operation);
        }

        [HttpPost]
        public IActionResult AddOperation([FromBody] Operation newOperation)
        {
            if (newOperation == null)
            {
                return BadRequest("Operation data is empty");
            }
            _context.Operations.Add(newOperation);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetOperationsById), new { id = newOperation.Id, newOperation });
        }

        [HttpPut("{id}")]
        public IActionResult UpdateOperation(int id, [FromBody] Operation updatedOperation)
        {
            var operation = _context.Operations.Find(id);

            if (operation == null)
            {
                return NotFound();
            }

            operation.ContainerId = updatedOperation.ContainerId;
            operation.StartDate = updatedOperation.StartDate;
            operation.EndDate = updatedOperation.EndDate;
            operation.OperationType = updatedOperation.OperationType;
            operation.OparatorFullName = updatedOperation.OparatorFullName;
            operation.InspectionPlace = updatedOperation.InspectionPlace;

            _context.Operations.Update(operation);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteOperation(int id)
        {
            var operation = _context.Operations.Find(id);

            if (operation == null)
            {
                return NotFound();
            }

            _context.Operations.Remove(operation);
            _context.SaveChanges();

            return NoContent();
        }
    }
}