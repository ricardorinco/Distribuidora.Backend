using DomainValidation.Validation;
using RR.Distribuidora.Domain.Constants;
using RR.Distribuidora.Domain.Interfaces.Repositories;
using RR.Distribuidora.Domain.Specifications.Regiao;

namespace RR.Distribuidora.Domain.Validations.Regiao
{
    public class RegiaoProntaParaRegistrarValidation : Validator<Models.Regiao>
    {
        public RegiaoProntaParaRegistrarValidation(IRegiaoRepository regiaoRepository)
        {
            var regiaoDeveConterEstadoEDescricaoUnicasSpecification = new RegiaoDeveConterEstadoEDescricaoUnicasSpecification(regiaoRepository);
            Add("regiaoDeveConterEstadoEDescricaoUnicasSpecification", new Rule<Models.Regiao>(regiaoDeveConterEstadoEDescricaoUnicasSpecification, ValidationsConstants.RegiaoDeveConterEstadoEDescricaoUnicas));
        }
    }
}
