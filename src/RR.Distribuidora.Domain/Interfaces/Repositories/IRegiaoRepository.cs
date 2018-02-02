using RR.Distribuidora.Domain.Models;

namespace RR.Distribuidora.Domain.Interfaces.Repositories
{
    public interface IRegiaoRepository : IRepository<Regiao>
    {
        Regiao Criar(Regiao regiao);
        Regiao Atualizar(Regiao regiao);

        Regiao BuscarPorDescricaoEstado(string descricao, int idEstado);
    }
}
