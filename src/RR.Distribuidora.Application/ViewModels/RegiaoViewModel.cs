using System.ComponentModel.DataAnnotations;

namespace RR.Distribuidora.Application.ViewModels
{
    public class RegiaoViewModel
    {
        public int IdRegiao { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }

        public int IdEstado { get; set; }
        public EstadoViewModel Estado { get; set; }

        [ScaffoldColumn(false)]
        public DomainValidation.Validation.ValidationResult ResultadoValidacao { get; set; }
    }
}
