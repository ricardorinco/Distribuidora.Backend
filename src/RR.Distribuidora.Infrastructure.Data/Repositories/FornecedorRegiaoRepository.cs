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
    public class FornecedorRegiaoRepository : IFornecedorRegiaoRepository
    {
        private readonly StringBuilder query = new StringBuilder();

        public FornecedorRegiao Criar(FornecedorRegiao fornecedorRegiao)
        {
            query.Length = 0;
            query.AppendLine("insert into FornecedorRegiao");
            query.AppendLine("            (IdFornecedor,");
            query.AppendLine("             IdRegiao)");
            query.AppendLine("     values (@IdFornecedor,");
            query.AppendLine("             @IdRegiao)");

            using (IDbConnection database = new SqlConnection(Context.ConnectionString))
            {
                database.Execute(query.ToString(), new
                {
                    IdFornecedor = fornecedorRegiao.IdFornecedor,
                    IdRegiao = fornecedorRegiao.IdRegiao
                });

                return fornecedorRegiao;
            }
        }
        public void Deletar(int idFornecedorRegiao)
        {
            query.Length = 0;
            query.AppendLine("delete from FornecedorRegiao");
            query.AppendLine(" where IdFornecedorRegiao = @IdFornecedorRegiao");

            using (IDbConnection database = new SqlConnection(Context.ConnectionString))
            {
                database.Execute(query.ToString(), new { IdFornecedorRegiao = idFornecedorRegiao });
            }
        }

        public FornecedorRegiao BuscarPorId(int idFornecedorRegiao)
        {
            query.Length = 0;
            query.AppendLine("select IdFornecedorRegiao,");
            query.AppendLine("       IdFornecedor,");
            query.AppendLine("       IdRegiao");
            query.AppendLine("  from FornecedorRegiao");
            query.AppendLine(" where IdFornecedorRegiao = @IdFornecedorRegiao");

            using (IDbConnection database = new SqlConnection(Context.ConnectionString))
            {
                return database.Query<FornecedorRegiao>(query.ToString(), new { IdFornecedorRegiao = idFornecedorRegiao }).SingleOrDefault();
            }
        }
        public IEnumerable<FornecedorRegiao> BuscarTodos()
        {
            query.Length = 0;
            query.AppendLine("select IdFornecedorRegiao,");
            query.AppendLine("       IdFornecedor,");
            query.AppendLine("       IdRegiao");
            query.AppendLine("  from FornecedorRegiao");

            using (IDbConnection database = new SqlConnection(Context.ConnectionString))
            {
                return database.Query<FornecedorRegiao>(query.ToString()).ToList();
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
