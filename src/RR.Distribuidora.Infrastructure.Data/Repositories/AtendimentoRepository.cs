using Dapper;
using RR.Distribuidora.Domain.Interfaces.Repositories;
using RR.Distribuidora.Domain.Models;
using RR.Distribuidora.Infrastructure.Data.Constants;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace RR.Distribuidora.Infrastructure.Data.Repositories
{
    public class AtendimentoRepository : IAtendimentoRepository
    {
        private readonly StringBuilder query = new StringBuilder();

        public Atendimento BuscarPorId(int idFornecedorRegiao)
        {
            query.Length = 0;
            query.AppendLine("select e.Descricao as Estado,");
            query.AppendLine("	     r.Descricao as Regiao,");
            query.AppendLine("	     r.Ativo,");
            query.AppendLine("	     fr.IdFornecedor");
            query.AppendLine("  from Regiao r");
            query.AppendLine("  left join FornecedorRegiao fr");
            query.AppendLine("    on fr.IdRegiao = r.IdRegiao");
            query.AppendLine(" inner join Estado e");
            query.AppendLine("    on e.IdEstado = r.IdEstado");
            query.AppendLine(" where fr.IdFornecedorRegiao = @IdFornecedorRegiao");

            using (IDbConnection database = new SqlConnection(Context.ConnectionString))
            {
                return database.Query<Atendimento>(query.ToString(), new { IdFornecedorRegiao = idFornecedorRegiao }).SingleOrDefault();
            }
        }
        public IEnumerable<Atendimento> BuscarTodos()
        {
            query.Length = 0;
            query.AppendLine("select e.Descricao as Estado,");
            query.AppendLine("	     r.Descricao as Regiao,");
            query.AppendLine("	     r.Ativo,");
            query.AppendLine("	     fr.IdFornecedor");
            query.AppendLine("  from Regiao r");
            query.AppendLine("  left join FornecedorRegiao fr");
            query.AppendLine("    on fr.IdRegiao = r.IdRegiao");
            query.AppendLine(" inner join Estado e");
            query.AppendLine("    on e.IdEstado = r.IdEstado");

            using (IDbConnection database = new SqlConnection(Context.ConnectionString))
            {
                return database.Query<Atendimento>(query.ToString()).ToList();
            }
        }

        public IEnumerable<Atendimento> BuscarPorIdFornecedor(int idFornecedor)
        {
            query.Length = 0;
            query.AppendLine("select fr.IdFornecedorRegiao,");
            query.AppendLine("       e.Descricao as Estado,");
            query.AppendLine("	     e.IdEstado,");
            query.AppendLine("	     r.Descricao as Regiao,");
            query.AppendLine("	     r.IdRegiao,");
            query.AppendLine("	     r.Ativo,");
            query.AppendLine("	     fr.IdFornecedor");
            query.AppendLine("  from Regiao r");
            query.AppendLine("  left join FornecedorRegiao fr");
            query.AppendLine("    on fr.IdRegiao = r.IdRegiao");
            query.AppendLine(" inner join Estado e");
            query.AppendLine("    on e.IdEstado = r.IdEstado");
            query.AppendLine(" where (fr.IdFornecedor = @IdFornecedor or fr.IdFornecedor is null)");
            query.AppendLine(" order by Estado, Regiao");

            using (IDbConnection database = new SqlConnection(Context.ConnectionString))
            {
                return database.Query<Atendimento>(query.ToString(), new { IdFornecedor = idFornecedor }).ToList();
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
