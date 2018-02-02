using AutoMapper;
using RR.Distribuidora.Application.Interfaces;
using RR.Distribuidora.Application.ViewModels;
using RR.Distribuidora.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace RR.Distribuidora.Application.Services
{
    public class AtendimentoApplicationService : IAtendimentoApplicationService
    {
        private readonly IAtendimentoService atendimento;

        public AtendimentoApplicationService(IAtendimentoService atendimento)
        {
            this.atendimento = atendimento;
        }

        public AtendimentoViewModel BuscarPorId(int id)
        {
            return Mapper.Map<AtendimentoViewModel>(atendimento.BuscarPorId(id));
        }
        public IEnumerable<AtendimentoViewModel> BuscarTodos()
        {
            return Mapper.Map<IEnumerable<AtendimentoViewModel>>(atendimento.BuscarTodos());
        }

        public IEnumerable<AtendimentoViewModel> BuscarPorIdFornecedor(int idFornecedor)
        {
            return Mapper.Map<IEnumerable<AtendimentoViewModel>>(atendimento.BuscarPorIdFornecedor(idFornecedor));
        }

        public void Dispose()
        {
            atendimento.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
