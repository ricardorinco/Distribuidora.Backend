using RR.Distribuidora.Domain.Models;

namespace RR.Distribuidora.Domain.Interfaces.Services
{
    public interface IRegiaoService : IService<Regiao>
    {
        Regiao Criar(Regiao regiao);
        Regiao Atualizar(Regiao regiao);
    }
}
