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
    public class FornecedorRepository : IFornecedorRepository
    {
        private readonly StringBuilder query = new StringBuilder();

        public Fornecedor BuscarPorId(int idFornecedor)
        {
            query.Length = 0;
            query.AppendLine("select IdFornecedor,");
            query.AppendLine("       CNPJ,");
            query.AppendLine("       Nome");
            query.AppendLine("  from Fornecedor");
            query.AppendLine(" where IdFornecedor = @IdFornecedor");
            query.AppendLine(" order by Nome");

            using (IDbConnection database = new SqlConnection(Context.ConnectionString))
            {
                return database.Query<Fornecedor>(query.ToString(), new { IdFornecedor = idFornecedor }).SingleOrDefault();
            }
        }
        public IEnumerable<Fornecedor> BuscarTodos()
        {
            query.Length = 0;
            query.AppendLine("select IdFornecedor,");
            query.AppendLine("       CNPJ,");
            query.AppendLine("       Nome");
            query.AppendLine("  from Fornecedor");
            query.AppendLine(" order by Nome");

            using (IDbConnection database = new SqlConnection(Context.ConnectionString))
            {
                return database.Query<Fornecedor>(query.ToString()).ToList();
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
