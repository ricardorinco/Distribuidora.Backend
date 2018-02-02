using AutoMapper;
using RR.Distribuidora.Application.Interfaces;
using RR.Distribuidora.Application.ViewModels;
using RR.Distribuidora.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace RR.Distribuidora.Application.Services
{
    public class FornecedorApplicationService : IFornecedorApplicationService
    {
        private readonly IFornecedorService fornecedorService;

        public FornecedorApplicationService(IFornecedorService fornecedorService)
        {
            this.fornecedorService = fornecedorService;
        }
        

        public FornecedorViewModel BuscarPorId(int idFornecedor)
        {
            return Mapper.Map<FornecedorViewModel>(fornecedorService.BuscarPorId(idFornecedor));
        }
        public IEnumerable<FornecedorViewModel> BuscarTodos()
        {
            return Mapper.Map<IEnumerable<FornecedorViewModel>>(fornecedorService.BuscarTodos());
        }

        public void Dispose()
        {
            fornecedorService.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
