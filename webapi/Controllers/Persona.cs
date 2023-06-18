using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using webapi.DB;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Persona : ControllerBase
    {


        [HttpPost]
        public async Task<ActionResult> PostAsync(DB.NewPersona newPersona)
        {
            using var db = new PadronContext();
            var persona = new DB.Persona
            {
                Apellidos = newPersona.Apellidos,
                Nombres = newPersona.Nombres,
                Sexo = newPersona.Sexo,
                Foto = newPersona.Foto,
                Cedula = newPersona.Cedula,
                Comentario = newPersona.Comentario,
                FechaNacimiento = newPersona.FechaNacimiento,
            };
            db.Personas.Add(persona);
            await db.SaveChangesAsync();

            return Ok();
        }


    }
}
