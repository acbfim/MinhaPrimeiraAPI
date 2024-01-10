using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace minhaprimeira.api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ClienteController : ControllerBase
    {
        [HttpGet]
        public string GetCliente()
        {
            return "Meu primeiro cliente";
        }
    }
}