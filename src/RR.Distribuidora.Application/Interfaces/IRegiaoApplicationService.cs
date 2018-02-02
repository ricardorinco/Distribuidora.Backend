using RR.Distribuidora.Application.ViewModels;

namespace RR.Distribuidora.Application.Interfaces
{
    public interface IRegiaoApplicationService : IApplicationService<RegiaoViewModel>
    {
        RegiaoViewModel Criar(RegiaoViewModel regiaoViewModel);
        RegiaoViewModel Atualizar(RegiaoViewModel regiaoViewModel);
    }
}
