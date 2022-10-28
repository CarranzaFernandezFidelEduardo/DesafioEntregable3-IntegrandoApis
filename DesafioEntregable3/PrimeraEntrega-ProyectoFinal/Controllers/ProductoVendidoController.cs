using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrimeraEntrega_ProyectoFinal.Models;
using PrimeraEntrega_ProyectoFinal.Repositories;

namespace PrimeraEntrega_ProyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoVendidoController : ControllerBase
    {
        ProductoVendidoRepository productoVendidoRepository;

        public ProductoVendidoController()
        {
            productoVendidoRepository = new ProductoVendidoRepository();
        }

        [HttpGet]
        public ActionResult ObtenerProductoVendido([FromQuery] int IdUsuario)
        {
            var result = productoVendidoRepository.TraerProductoVendido(IdUsuario);
            return Ok(result);
        }

       

    }
}
