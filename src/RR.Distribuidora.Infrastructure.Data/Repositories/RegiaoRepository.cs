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
    public class RegiaoRepository : IRegiaoRepository
    {
        private readonly StringBuilder query = new StringBuilder();

        public Regiao Criar(Regiao regiao)
        {
            query.Length = 0;
            query.AppendLine("insert into Regiao");
            query.AppendLine("            (IdEstado,");
            query.AppendLine("             Descricao,");
            query.AppendLine("             Ativo)");
            query.AppendLine("     values (@IdEstado,");
            query.AppendLine("             @Descricao,");
            query.AppendLine("             @Ativo)");

            using (IDbConnection database = new SqlConnection(Context.ConnectionString))
            {
                database.Execute(query.ToString(), new
                {
                    IdEstado = regiao.IdEstado,
                    Descricao = regiao.Descricao,
                    Ativo = regiao.Ativo
                });

                return regiao;
            }
        }
        public Regiao Atualizar(Regiao regiao)
        {
            query.Length = 0;
            query.AppendLine("update Regiao");
            query.AppendLine("   set IdEstado = @IdEstado,");
            query.AppendLine("       Descricao = @Descricao,");
            query.AppendLine("       Ativo = @Ativo");
            query.AppendLine(" where IdRegiao = @IdRegiao");

            using (IDbConnection database = new SqlConnection(Context.ConnectionString))
            {
                database.Execute(query.ToString(), new {
                    IdEstado = regiao.IdEstado,
                    Descricao = regiao.Descricao,
                    Ativo = regiao.Ativo,
                    IdRegiao = regiao.IdRegiao
                });

                return regiao;
            }
        }

        public Regiao BuscarPorId(int idRegiao)
        {
            query.Length = 0;
            query.AppendLine("select r.IdRegiao,");
            query.AppendLine("       r.IdEstado,");
            query.AppendLine("       r.Descricao,");
            query.AppendLine("       r.Ativo,");
            query.AppendLine("       e.IdEstado,");
            query.AppendLine("       e.Descricao");
            query.AppendLine("  from Regiao r");
            query.AppendLine(" inner join Estado e");
            query.AppendLine("    on e.IdEstado = r.IdEstado");
            query.AppendLine(" where r.IdRegiao = @IdRegiao");
            query.AppendLine(" order by e.Descricao, r.Descricao");

            using (IDbConnection database = new SqlConnection(Context.ConnectionString))
            {
                return database.Query<Regiao, Estado, Regiao>(
                    query.ToString(),
                    (regiao, estado) =>
                    {
                        regiao.Estado = estado;
                        return regiao;
                    }, new { IdRegiao = idRegiao }, splitOn: "IdEstado, IdEstado").SingleOrDefault();
            }
        }
        public IEnumerable<Regiao> BuscarTodos()
        {
            query.Length = 0;
            query.AppendLine("select r.IdRegiao,");
            query.AppendLine("       r.IdEstado,");
            query.AppendLine("       r.Descricao,");
            query.AppendLine("       r.Ativo,");
            query.AppendLine("       e.IdEstado,");
            query.AppendLine("       e.Descricao");
            query.AppendLine("  from Regiao r");
            query.AppendLine(" inner join Estado e");
            query.AppendLine("    on e.IdEstado = r.IdEstado");
            query.AppendLine(" order by e.Descricao, r.Descricao");

            using (IDbConnection database = new SqlConnection(Context.ConnectionString))
            {
                return database.Query<Regiao, Estado, Regiao>(
                    query.ToString(),
                    (regiao, estado) =>
                    {
                        regiao.Estado = estado;
                        return regiao;
                    }, splitOn: "IdEstado, IdEstado").ToList();
            }
        }

        public Regiao BuscarPorDescricaoEstado(string descricao, int idEstado)
        {
            query.Length = 0;
            query.AppendLine("select Descricao,");
            query.AppendLine("       IdEstado");
            query.AppendLine("  from Regiao");
            query.AppendLine(" where Descricao = @Descricao");
            query.AppendLine("   and IdEstado = @IdEstado");
            using (IDbConnection database = new SqlConnection(Context.ConnectionString))
            {
                return database.Query<Regiao>(query.ToString(), new { Descricao = descricao, IdEstado = idEstado }).SingleOrDefault();
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
