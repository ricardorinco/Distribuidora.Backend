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
    public class EstadoRepository : IEstadoRepository
    {
        private readonly StringBuilder query = new StringBuilder();

        public Estado BuscarPorId(int idEstado)
        {
            query.Length = 0;
            query.AppendLine("select IdEstado,");
            query.AppendLine("       Descricao");
            query.AppendLine("  from Estado");
            query.AppendLine(" where IdEstado = @IdEstado");
            query.AppendLine(" order by Descricao");

            using (IDbConnection database = new SqlConnection(Context.ConnectionString))
            {
                return database.Query<Estado>(query.ToString(), new { IdEstado = idEstado }).SingleOrDefault();
            }
        }
        public IEnumerable<Estado> BuscarTodos()
        {
            query.Length = 0;
            query.AppendLine("select IdEstado,");
            query.AppendLine("       Descricao");
            query.AppendLine("  from Estado");

            using (IDbConnection database = new SqlConnection(Context.ConnectionString))
            {
                return database.Query<Estado>(query.ToString()).ToList();
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
