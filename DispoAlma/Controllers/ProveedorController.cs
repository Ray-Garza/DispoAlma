using Microsoft.AspNetCore.Mvc;
using DispoAlma.Entidades;
using Microsoft.EntityFrameworkCore;
namespace DispoAlma.Controllers
{
    [ApiController]
    [Route("/proveedor")]
    public class ProveedorController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ProveedorController(ApplicationDbContext context) 
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Proveedor>>> GetAll()
        {
            return await _context.Proveedores.ToListAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Proveedor>> GetById(int id)
        {
            return await _context.Proveedores.FirstOrDefaultAsync(x => x.Id == id);
        }

        [HttpPost]
        public async Task<ActionResult> Post(Proveedor proveedor)
        {
            _context.Add(proveedor);
            await _context.SaveChangesAsync();
            return Ok();
            
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(Proveedor proveedor, int id)
        {
            //o:28.31
            if (proveedor.Id != id)
            {
                return BadRequest("El id del proveedor no coincide con el id de la url");
            }

            _context.Update(proveedor);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var exist = await _context.Proveedores.AnyAsync(x => x.Id == id);

            if (!exist)
            {
                return NotFound("No se encontró el registro en la base de datos.");
            }
            _context.Remove(new Proveedor() { Id = id });
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
