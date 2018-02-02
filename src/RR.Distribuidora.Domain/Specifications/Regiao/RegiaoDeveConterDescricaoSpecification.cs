using DomainValidation.Interfaces.Specification;

namespace RR.Distribuidora.Domain.Specifications.Regiao
{
    public class RegiaoDeveConterDescricaoSpecification : ISpecification<Models.Regiao>
    {
        public bool IsSatisfiedBy(Models.Regiao regiao)
        {
            return !string.IsNullOrWhiteSpace(regiao.Descricao);
        }
    }
}
