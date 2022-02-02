using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApiAutores.Entidades;

namespace WebApiAutores.Controllers
{
    [Route("api/autores")]
    [ApiController]
    public class AutoresController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Autor>> Get()
        {
            return new List<Autor>
            {
                new Autor{ Id = 1, Name ="Diego"},
                new Autor{ Id = 2, Name = "Marcelos"}
            };
        }
    }
}
