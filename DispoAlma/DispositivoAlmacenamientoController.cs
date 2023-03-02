using Microsoft.AspNetCore.Mvc;
using DispoAlma.Entidades;

namespace DispoAlma
{
    [ApiController]
    [Route("api/dispositivos")]
    public class DispositivoAlmacenamientoController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<DispositivoAlmacenamiento>> Get() {
            return new List<DispositivoAlmacenamiento>(){
                new DispositivoAlmacenamiento() { id_dispositivo = 1, nombre_dispositivo = "Disco SSD Acer"},
                new DispositivoAlmacenamiento() { id_dispositivo = 2, nombre_dispositivo = "Disco HDD Acer"}
            };
        }
    }
}
