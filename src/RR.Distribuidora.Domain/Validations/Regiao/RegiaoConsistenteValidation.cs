using DomainValidation.Validation;
using RR.Distribuidora.Domain.Constants;
using RR.Distribuidora.Domain.Specifications.Regiao;

namespace RR.Distribuidora.Domain.Validations.Regiao
{
    public class RegiaoConsistenteValidation : Validator<Models.Regiao>
    {
        public RegiaoConsistenteValidation()
        {
            var regiaoDeveConterDescricaoSpecification = new RegiaoDeveConterDescricaoSpecification();
            Add("regiaoDeveConterDescricaoSpecification", new Rule<Models.Regiao>(regiaoDeveConterDescricaoSpecification, ValidationsConstants.RegiaoDeveConterDescricao));

            var regiaoDeveConterIdEstadoSpecification = new RegiaoDeveConterIdEstadoSpecification();
            Add("regiaoDeveConterIdEstadoSpecification", new Rule<Models.Regiao>(regiaoDeveConterIdEstadoSpecification, ValidationsConstants.RegiaoDeveConterIdEstado));
        }
    }
}
