using RR.Distribuidora.Domain.Models;

namespace RR.Distribuidora.Domain.Interfaces.Services
{
    public interface IFornecedorRegiaoService : IService<FornecedorRegiao>
    {
        FornecedorRegiao Criar(FornecedorRegiao fornecedorRegiao);
        void Deletar(int idFornecedorRegiao);
    }
}
