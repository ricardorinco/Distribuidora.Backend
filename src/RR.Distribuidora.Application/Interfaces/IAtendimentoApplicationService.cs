using RR.Distribuidora.Application.ViewModels;
using System.Collections.Generic;

namespace RR.Distribuidora.Application.Interfaces
{
    public interface IAtendimentoApplicationService : IApplicationService<AtendimentoViewModel>
    {
        IEnumerable<AtendimentoViewModel> BuscarPorIdFornecedor(int idFornecedor);
    }
}
