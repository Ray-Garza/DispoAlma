using Microsoft.AspNetCore.Mvc;
using DispoAlma.Entidades;
using Microsoft.EntityFrameworkCore;
using System.Timers;

namespace DispoAlma.Controllers
{
    [ApiController]
    [Route("api/dispositivos")]
    public class DispositivoAlmacenamientoController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public DispositivoAlmacenamientoController(ApplicationDbContext context)
        {
            _context = context;
        }



        [HttpGet]
        public ActionResult<List<DispositivoAlmacenamiento>> Get()
        {
            return new List<DispositivoAlmacenamiento>(){
                new DispositivoAlmacenamiento() { Id = 1, 
                                                  Nombre_dispositivo = "Disco SSD Acer NVMe", 
                                                  Almacenamiento_dispositivo = 1000, 
                                                  Descripcion_dispositivo= "SSD Acer FA100 NVMe, 1TB, PCI Express 3.0, M.2",
                                                  Velocidad_escritura=2700,
                                                  Velocidad_lectura=3300,
                                                  Cantidad = 200},

                new DispositivoAlmacenamiento() { Id = 2, 
                                                  Nombre_dispositivo = "Disco SSD Acer SATA",
                                                  Almacenamiento_dispositivo = 960,
                                                  Descripcion_dispositivo= "SSD Acer SA100, 960GB, SATA III, 2.5",
                                                  Velocidad_escritura=560,
                                                  Velocidad_lectura=500,
                                                  Cantidad = 150},
            };
        }

        [HttpPost]
        public async Task<ActionResult> Post(DispositivoAlmacenamiento dispositivoAlmacenamiento)
        {
            var existeProveedor = await _context.Proveedores.AnyAsync(x => x.Id == dispositivoAlmacenamiento.ProveedorId);

            if (!existeProveedor)
            {
                return BadRequest("No existe Proveedor");
            }

            _context.Add(dispositivoAlmacenamiento);

            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpGet("/lista")]
        public async Task<ActionResult<List<DispositivoAlmacenamiento>>> GetAll()
        {
            return await _context.DispositivoAlmacenamientos.ToListAsync();
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(DispositivoAlmacenamiento dispositivoAlmacenamiento, int id)
        {
            var existeDispositivo = await _context.DispositivoAlmacenamientos.AnyAsync(x => x.Id == dispositivoAlmacenamiento.Id);

            if (!existeDispositivo)
            {
                return BadRequest("No existe dispositivo");
            }

            if(dispositivoAlmacenamiento.Id != id)
            {
                return BadRequest("El id del dispositivo no coincide con el id de la url");
            }

            _context.Update(dispositivoAlmacenamiento);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var exist = await _context.DispositivoAlmacenamientos.AnyAsync(x => x.Id == id);

            if (!exist)
            {
                return NotFound("No se encontró el registro en la base de datos.");
            }
            _context.Remove(new DispositivoAlmacenamiento() { Id = id});
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
