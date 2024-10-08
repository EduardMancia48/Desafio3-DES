using Desafio3_DM201736_DV201086_PC191777.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Desafio3_DM201736_DV201086_PC191777.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolController : ControllerBase
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<Usuario> _userManager;

        public RolController(RoleManager<IdentityRole> roleManager, UserManager<Usuario> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        // Acción para crear un nuevo rol
        // [Authorize(Roles = "Administrador")]
        [HttpPost("crear")]
        public async Task<IActionResult> CrearRol([FromBody] NombreRol modelo)
        {
            if (string.IsNullOrWhiteSpace(modelo?.Rol))
            {
                return BadRequest("El nombre del rol es obligatorio.");
            }

            // Verificar si el rol ya existe
            if (await _roleManager.RoleExistsAsync(modelo.Rol))
            {
                return Conflict($"El rol '{modelo.Rol}' ya está registrado.");
            }

            // Crear el rol
            var resultado = await _roleManager.CreateAsync(new IdentityRole(modelo.Rol));
            if (resultado.Succeeded)
            {
                return Ok($"El rol '{modelo.Rol}' se ha creado exitosamente.");
            }

            return BadRequest("Ocurrió un error al intentar crear el rol.");
        }

        // Acción para asignar un rol a un usuario existente
        // [Authorize(Roles = "Administrador")]
        [HttpPost("asignar")]
        public async Task<IActionResult> AsignarRol([FromBody] Roles modelo)
        {
            if (string.IsNullOrWhiteSpace(modelo.Correo) || string.IsNullOrWhiteSpace(modelo.NombreRol))
            {
                return BadRequest("El correo del usuario y el nombre del rol son campos obligatorios.");
            }

            // Buscar el usuario por su correo electrónico
            var usuario = await _userManager.FindByEmailAsync(modelo.Correo);
            if (usuario == null)
            {
                return NotFound($"No se encontró ningún usuario con el correo '{modelo.Correo}'.");
            }

            // Verificar si el rol existe
            if (!await _roleManager.RoleExistsAsync(modelo.NombreRol))
            {
                return BadRequest($"El rol '{modelo.NombreRol}' no está registrado.");
            }

            // Asignar el rol al usuario
            var resultado = await _userManager.AddToRoleAsync(usuario, modelo.NombreRol);
            if (resultado.Succeeded)
            {
                return Ok($"El rol '{modelo.NombreRol}' ha sido asignado correctamente al usuario '{modelo.Correo}'.");
            }

            return BadRequest("Ocurrió un error al intentar asignar el rol.");
        }
    }
}
