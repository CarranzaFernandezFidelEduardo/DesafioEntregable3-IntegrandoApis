using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrimeraEntrega_ProyectoFinal.Models;
using PrimeraEntrega_ProyectoFinal.Repositories;

namespace PrimeraEntrega_ProyectoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        UsuarioRepository usuarioRepository;

        public UsuarioController()
        {
            usuarioRepository = new UsuarioRepository();
        }

        [HttpGet("ObtenerUsuario")]
        public ActionResult ObtenerUsuario([FromQuery] string NombreUsuario)
        {
            var result = usuarioRepository.TraerUsuario(NombreUsuario);

            if (result.Count >= 1) 
            {
                return Ok(result);
            }
            else
            {
                return Ok("No existe usuarios con el nombre de usuario ingresado");
            }
        }

        [HttpGet("InicioDeSesion")]
        public ActionResult InicioSesion([FromQuery] string NombreUsuario, string Contra)
        {
            var result = usuarioRepository.InicioDeSesion(NombreUsuario, Contra);

            return Ok(result);
        }

        [HttpPut] 
        public void ModificarUsuario([FromQuery] Usuario usuario)
        {
            usuarioRepository.ModificarUsuario(usuario);

        }


    }
}
