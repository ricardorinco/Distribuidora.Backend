using RR.Distribuidora.Application.ViewModels;

namespace RR.Distribuidora.Application.Interfaces
{
    public interface IFornecedorRegiaoApplicationService : IApplicationService<FornecedorRegiaoViewModel>
    {
        FornecedorRegiaoViewModel Criar(FornecedorRegiaoViewModel fornecedorRegiaoViewModel);
        void Deletar(int idFornecedorRegiaoViewModel);
    }
}
