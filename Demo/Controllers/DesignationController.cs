using Demo.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Demo.Controllers
{
    
    
    [Route("api/[controller]")]
    [ApiController]
    public class DesignationController : ControllerBase
    {

        private readonly EmployeeContext _context;
        public DesignationController(EmployeeContext context)
        {
            _context = context;
        }
        // GET: api/lDesignation
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TblDesignation>>> GetTblDesignation()
        {
            return await _context.TblDesignation.ToListAsync();
        }

    }


}
