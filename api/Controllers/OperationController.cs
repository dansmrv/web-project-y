using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers{
    public class OperationController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public OperationController(ApplicationDBContext context)
        {
            this._context = context;
        }       
        
        [HttpGet] 
        public IActionResult GetAllOperations(){
            //Берем из бд
            var operations = _context.Operations.ToList();
            return Ok(operations);
        }

        [HttpGet("{id}")]
        public IActionResult GetOperationsById([FromRoute] int id){
            var operation = _context.Operations.Find(id);

            if(operation == null){
                return NotFound();
            }
            
            return Ok(operation);
        }
    }
}