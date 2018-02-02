using RR.Distribuidora.Domain.Models;
using System.Collections.Generic;

namespace RR.Distribuidora.Domain.Interfaces.Repositories
{
    public interface IAtendimentoRepository : IRepository<Atendimento>
    {
        IEnumerable<Atendimento> BuscarPorIdFornecedor(int idFornecedor);
    }
}
