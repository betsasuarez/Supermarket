using Microsoft.AspNetCore.Mvc;
using RecaudacioneAPI.Services;

namespace RecaudacioneAPI.Controllers
{
    [Route("api/recaudaciones")]
    [ApiController]
    public class RecaudacionesController : ControllerBase
    {
        private readonly IRecaudacionesService _recaudacionesService;

        public RecaudacionesController(IRecaudacionesService recaudacionesService)
        {
            _recaudacionesService = recaudacionesService;
        }

        [HttpGet("cliente/{clienteId}")]
        public ActionResult<decimal> ObtenerValorAPagarCliente(int clienteId)
        {
            try
            {
                var valorAPagar = _recaudacionesService.ObtenerValorAPagarCliente(clienteId);
                return Ok(valorAPagar);
            }
            catch (InvalidOperationException ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet("producto/{productoId}")]
        public ActionResult<decimal> ObtenerPrecioProducto(int productoId)
        {
            try
            {
                var precioProducto = _recaudacionesService.ObtenerPrecioProducto(productoId);
                return Ok(precioProducto);
            }
            catch (InvalidOperationException ex)
            {
                return NotFound(ex.Message);
            }
        }
    }

}
