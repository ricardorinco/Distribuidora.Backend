using System;
using System.Collections.Generic;

namespace RR.Distribuidora.Application.Interfaces
{
    public interface IApplicationService<TEntidade> : IDisposable where TEntidade : class
    {
        TEntidade BuscarPorId(int id);
        IEnumerable<TEntidade> BuscarTodos();
    }
}
