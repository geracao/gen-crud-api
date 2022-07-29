using API.Data;
using API.Model;
using Microsoft.EntityFrameworkCore;

namespace API.Repository
{
    public class MembroRepository : IMembroRepository
    {
        private readonly MembroContext _context;

        public MembroRepository(MembroContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Membro>> BuscaMembros()
        {
            return await _context.Membros.ToListAsync();
        }
        public async Task<Membro> BuscaMembro(int id)
        {
             return await _context.Membros.Where(x => x.Id == id).FirstOrDefaultAsync();
        }
        public void AdicionaMembro(Membro membro)
        {
            _context.Add(membro);
        }
        public void AtualizaMembro(Membro membro)
        {
            _context.Update(membro);
        }
        public void DeletaMembro(Membro membro)
        {
            _context.Remove(membro);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}