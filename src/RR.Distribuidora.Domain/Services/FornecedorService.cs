using RR.Distribuidora.Domain.Interfaces.Repositories;
using RR.Distribuidora.Domain.Interfaces.Services;
using RR.Distribuidora.Domain.Models;
using System;
using System.Collections.Generic;

namespace RR.Distribuidora.Domain.Services
{
    public class FornecedorService : IFornecedorService
    {
        private readonly IFornecedorRepository fornecedorRepository;

        public FornecedorService(IFornecedorRepository fornecedorRepository)
        {
            this.fornecedorRepository = fornecedorRepository;
        }

        public Fornecedor BuscarPorId(int idFornecedor)
        {
            return fornecedorRepository.BuscarPorId(idFornecedor);
        }
        public IEnumerable<Fornecedor> BuscarTodos()
        {
            return fornecedorRepository.BuscarTodos();
        }

        public void Dispose()
        {
            fornecedorRepository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
