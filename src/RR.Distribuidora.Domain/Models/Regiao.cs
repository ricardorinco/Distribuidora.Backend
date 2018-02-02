using DomainValidation.Validation;
using RR.Distribuidora.Domain.Validations.Regiao;

namespace RR.Distribuidora.Domain.Models
{
    public class Regiao
    {
        public int IdRegiao { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }

        public int IdEstado { get; set; }
        public Estado Estado { get; set; }

        public ValidationResult ResultadoValidacao { get; set; }

        public bool IsValid()
        {
            ResultadoValidacao = new RegiaoConsistenteValidation().Validate(this);

            return ResultadoValidacao.IsValid;
        }
    }
}
