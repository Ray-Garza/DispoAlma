using Microsoft.AspNetCore.Mvc;
using DispoAlma.Entidades;

namespace DispoAlma.Controllers
{
    [ApiController]
    [Route("api/dispositivos")]
    public class DispositivoAlmacenamientoController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<DispositivoAlmacenamiento>> Get()
        {
            return new List<DispositivoAlmacenamiento>(){
                new DispositivoAlmacenamiento() { id_dispositivo = 1, 
                                                  nombre_dispositivo = "Disco SSD Acer NVMe", 
                                                  almacenamiento_dispositivo = 1000, 
                                                  descripcion_dispositivo= "SSD Acer FA100 NVMe, 1TB, PCI Express 3.0, M.2",
                                                  velocidad_escritura=2700,
                                                  velocidad_lectura=3300,
                                                  cantidad = 200},

                new DispositivoAlmacenamiento() { id_dispositivo = 2, nombre_dispositivo = "Disco SSD Acer SATA",
                                                  almacenamiento_dispositivo = 960,
                                                  descripcion_dispositivo= "SSD Acer SA100, 960GB, SATA III, 2.5",
                                                  velocidad_escritura=560,
                                                  velocidad_lectura=500,
                                                  cantidad = 150},
            };
        }
    }
}
