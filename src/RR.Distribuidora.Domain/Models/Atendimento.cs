namespace RR.Distribuidora.Domain.Models
{
    public class Atendimento
    {
        public int IdFornecedorRegiao { get; set; }

        public int IdEstado { get; set; }
        public string Estado { get; set; }

        public int IdRegiao { get; set; }
        public string Regiao { get; set; }

        public bool Ativo { get; set; }
        public int IdFornecedor { get; set; }
    }
}
