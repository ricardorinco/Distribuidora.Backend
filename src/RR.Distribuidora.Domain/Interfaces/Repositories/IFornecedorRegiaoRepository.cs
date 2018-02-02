using RR.Distribuidora.Domain.Models;

namespace RR.Distribuidora.Domain.Interfaces.Repositories
{
    public interface IFornecedorRegiaoRepository : IRepository<FornecedorRegiao>
    {
        FornecedorRegiao Criar(FornecedorRegiao fornecedorRegiao);
        void Deletar(int idFornecedorRegiao);
    }
}
