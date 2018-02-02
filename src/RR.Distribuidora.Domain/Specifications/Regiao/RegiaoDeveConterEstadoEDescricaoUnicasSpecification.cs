using DomainValidation.Interfaces.Specification;
using RR.Distribuidora.Domain.Interfaces.Repositories;

namespace RR.Distribuidora.Domain.Specifications.Regiao
{
    public class RegiaoDeveConterEstadoEDescricaoUnicasSpecification : ISpecification<Models.Regiao>
    {
        private readonly IRegiaoRepository regiaoRepository;

        public RegiaoDeveConterEstadoEDescricaoUnicasSpecification(IRegiaoRepository regiaoRepository)
        {
            this.regiaoRepository = regiaoRepository;
        }

        public bool IsSatisfiedBy(Models.Regiao regiao)
        {
            if (string.IsNullOrWhiteSpace(regiao.Descricao))
                return false;

            if (regiao.IdEstado == 0)
                return false;

            return regiaoRepository.BuscarPorDescricaoEstado(regiao.Descricao, regiao.IdEstado) == null;
        }
    }
}
