using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase 
    {
        [HttpGet]
        public IActionResult obterUsuario()
        {
            return Ok("Hello World!");
        }
    }
}