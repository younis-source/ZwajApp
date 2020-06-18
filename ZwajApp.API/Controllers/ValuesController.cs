using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZwajApp.API.Data;

namespace ZwajApp.API.Controllers
{
    [Authorize]
     [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _context;
        public ValuesController(DataContext context)
        {
            _context = context;
            
        }
         [HttpGet]
         public async Task<IActionResult> GetValues() 
         {
             var values = await _context.Values.ToListAsync();
             return Ok(values);
         }
        
        [AllowAnonymous]        
         [HttpGet("{id}")]
         public async Task< IActionResult> GetValue(int id)
         {
             var value = await _context.Values.FirstOrDefaultAsync(x=>x.Id==id);
             return Ok(value);  
         }
        
    }
}