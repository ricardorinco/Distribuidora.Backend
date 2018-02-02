using DomainValidation.Interfaces.Specification;

namespace RR.Distribuidora.Domain.Specifications.Regiao
{
    public class RegiaoDeveConterIdEstadoSpecification : ISpecification<Models.Regiao>
    {
        public bool IsSatisfiedBy(Models.Regiao regiao)
        {
            return regiao.IdEstado > 0;
        }
    }
}
