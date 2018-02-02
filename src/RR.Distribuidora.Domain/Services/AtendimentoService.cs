using RR.Distribuidora.Domain.Interfaces.Repositories;
using RR.Distribuidora.Domain.Interfaces.Services;
using RR.Distribuidora.Domain.Models;
using System;
using System.Collections.Generic;

namespace RR.Distribuidora.Domain.Services
{
    public class AtendimentoService : IAtendimentoService
    {
        private readonly IAtendimentoRepository atendimentoRepository;

        public AtendimentoService(IAtendimentoRepository atendimentoRepository)
        {
            this.atendimentoRepository = atendimentoRepository;
        }

        public Atendimento BuscarPorId(int idFornecedor)
        {
            return atendimentoRepository.BuscarPorId(idFornecedor);
        }
        public IEnumerable<Atendimento> BuscarTodos()
        {
            return atendimentoRepository.BuscarTodos();
        }

        public IEnumerable<Atendimento> BuscarPorIdFornecedor(int idFornecedor)
        {
            return atendimentoRepository.BuscarPorIdFornecedor(idFornecedor);
        }

        public void Dispose()
        {
            atendimentoRepository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
