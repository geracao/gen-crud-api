using API.Model;
using Microsoft.AspNetCore.Mvc;
using API.Repository;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MembroController : ControllerBase
    {
        private readonly IMembroRepository _repository;

        public MembroController(IMembroRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var membros = await _repository.BuscaMembros();
            return membros.Any()
                ? Ok(membros)
                : NoContent();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var membro = await _repository.BuscaMembro(id);
            return membro != null
                ? Ok(membro)
                : NotFound("Membro não encontrado");
        }

        [HttpPost]
        public async Task<IActionResult> Post(Membro membro)
        {
            _repository.AdicionaMembro(membro);

            return await _repository.SaveChangesAsync()
                ? Ok("Membro adicionado com sucesso")
                : BadRequest("Erro ao adicionar membro");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Membro membro)
        {
            var membroBanco = await _repository.BuscaMembro(id);
            if (membroBanco == null) return NotFound("Membro não encontrado");

            membroBanco.Nome = membro.Nome ?? membroBanco.Nome;
            membroBanco.Email = membro.Email ?? membroBanco.Email;
            membroBanco.Github = membro.Github ?? membroBanco.Github;
            membroBanco.Phone = membro.Phone ?? membroBanco.Phone;

            _repository.AtualizaMembro(membroBanco);

            return await _repository.SaveChangesAsync()
                ? Ok("Membro atualizado com sucesso")
                : BadRequest("Erro ao atualizar membro");

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var membroBanco = await _repository.BuscaMembro(id);
            if (membroBanco == null) return NotFound("Membro não encontrado");

            _repository.DeletaMembro(membroBanco);

            return await _repository.SaveChangesAsync()
                ? Ok("Membro deletado com sucesso")
                : BadRequest("Erro ao deletar membro");
        }
    }
}