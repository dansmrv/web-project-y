using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using Microsoft.AspNetCore.Mvc;

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
      
        
    }
}