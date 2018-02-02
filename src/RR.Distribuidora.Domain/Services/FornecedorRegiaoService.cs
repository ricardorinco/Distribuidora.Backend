using RR.Distribuidora.Domain.Interfaces.Repositories;
using RR.Distribuidora.Domain.Interfaces.Services;
using RR.Distribuidora.Domain.Models;
using System;
using System.Collections.Generic;

namespace RR.Distribuidora.Domain.Services
{
    public class FornecedorRegiaoService : IFornecedorRegiaoService
    {
        private readonly IFornecedorRegiaoRepository fornecedorRegiaoRepository;

        public FornecedorRegiaoService(IFornecedorRegiaoRepository fornecedorRegiaoRepository)
        {
            this.fornecedorRegiaoRepository = fornecedorRegiaoRepository;
        }

        public FornecedorRegiao Criar(FornecedorRegiao fornecedorRegiao)
        {
            return fornecedorRegiaoRepository.Criar(fornecedorRegiao);
        }
        public void Deletar(int idFornecedorRegiao)
        {
            fornecedorRegiaoRepository.Deletar(idFornecedorRegiao);
        }

        public FornecedorRegiao BuscarPorId(int idEstado)
        {
            return fornecedorRegiaoRepository.BuscarPorId(idEstado);
        }
        public IEnumerable<FornecedorRegiao> BuscarTodos()
        {
            return fornecedorRegiaoRepository.BuscarTodos();
        }

        public void Dispose()
        {
            fornecedorRegiaoRepository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
