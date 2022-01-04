using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Server.Data;
using WebApplication1.Shared;

namespace WebApplication1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemoryController : ControllerBase
    {
        private readonly AppDbContext context;

        public MemoryController(AppDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetMemories()
        {
            var result = this.context.Memories.ToList();
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMemory(int id)
        {
            var result = this.context.Memories.FirstOrDefault(memory => memory.Id == id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMemory([FromBody]Memory_ newMemory)
        {
            await this.context.Memories.AddAsync(newMemory);

            await this.context.SaveChangesAsync();
            return Ok("");

        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteMemory(int id)
        {
            var result = this.context.Memories.FirstOrDefault(memory => memory.Id == id);
            
            this.context.Memories.Remove(result);

            this.context.SaveChanges();

            return Ok("");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateMemory([FromBody]Memory_ newMemory)
        {
            var result = this.context.Memories.FirstOrDefault(memory => memory.Id == newMemory.Id);

            result.Expression = newMemory.Expression;

            result.Result = newMemory.Result;
            this.context.SaveChanges();

            return Ok("");


        }


    }
}
