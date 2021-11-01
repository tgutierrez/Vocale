using Microsoft.AspNetCore.Mvc;
using Vocale.Core.Base;
using Vocale.Core.Base.Votacion;

namespace Vocale.API.Controllers {

    [ApiController]
    [ApiVersion("1.0")]
    [Route("v{version:apiVersion}/[controller]")]
    [Produces("application/json")]
    public class MesaController : ControllerBase {
        
        [HttpGet()]
        [Route("{id}")]
        public Mesa GetMesa(int id){
            return new Mesa{ 
                Numero = id,
                Estado = new Constitucion { Estado = Estado.NoConstituida, Actualizacion = System.DateTime.Now }
            };
        }

        [HttpGet()]
        [Route("{id}/votacion")]
        public Resumen GetVotacion(int id){
            return new Resumen();
        }

    }

}