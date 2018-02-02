using RR.Distribuidora.Domain.Models;
using System.Collections.Generic;

namespace RR.Distribuidora.Domain.Interfaces.Services
{
    public interface IAtendimentoService : IService<Atendimento>
    {
        IEnumerable<Atendimento> BuscarPorIdFornecedor(int idFornecedor);
    }
}
