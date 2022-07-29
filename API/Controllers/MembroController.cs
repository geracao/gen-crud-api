using API.Model;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MembroController : ControllerBase
    {
        private static List<Membro> Membros()
        {
            return new List<Membro>{
                new Membro{ Id = 1, Nome = "CarlaoViado", Email = "carlaocuminista2@gmail.com", Github = "carlitosgame1997", Phone = "15 99181-0886"}
            };
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Membros());
        }

        [HttpPost]
        public IActionResult Post(Membro membro)
        {
            var membros = Membros();
            membros.Add(membro);
            return Ok(membro);
        }
    }
}