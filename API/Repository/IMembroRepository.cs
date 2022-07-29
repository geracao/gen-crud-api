using API.Model;

namespace API.Repository
{
    public interface IMembroRepository
    {
        Task <IEnumerable<Membro>> BuscaMembros();
        Task <Membro> BuscaMembro(int id);
        void AdicionaMembro(Membro membro);
        void AtualizaMembro(Membro membro);
        void DeletaMembro(Membro membro);

        Task<bool> SaveChangesAsync();
    }
}