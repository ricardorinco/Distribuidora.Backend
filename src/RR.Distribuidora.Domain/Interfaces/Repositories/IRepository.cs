using System;
using System.Collections.Generic;

namespace RR.Distribuidora.Domain.Interfaces.Repositories
{
    public interface IRepository<TEntidade> : IDisposable where TEntidade : class
    {
        TEntidade BuscarPorId(int id);
        IEnumerable<TEntidade> BuscarTodos();
    }
}
