using System;
using System.Collections.Generic;

namespace RR.Distribuidora.Domain.Interfaces.Services
{
    public interface IService<TEntidade> : IDisposable where TEntidade : class
    {
        TEntidade BuscarPorId(int id);
        IEnumerable<TEntidade> BuscarTodos();
    }
}
