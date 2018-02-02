using AutoMapper;
using RR.Distribuidora.Application.Interfaces;
using RR.Distribuidora.Application.ViewModels;
using RR.Distribuidora.Domain.Interfaces.Services;
using RR.Distribuidora.Domain.Models;
using System;
using System.Collections.Generic;

namespace RR.Distribuidora.Application.Services
{
    public class FornecedorRegiaoApplicationService : IFornecedorRegiaoApplicationService
    {
        private readonly IFornecedorRegiaoService fornecedorRegiaoService;

        public FornecedorRegiaoApplicationService(IFornecedorRegiaoService fornecedorRegiaoService)
        {
            this.fornecedorRegiaoService = fornecedorRegiaoService;
        }

        public FornecedorRegiaoViewModel Criar(FornecedorRegiaoViewModel fornecedorRegiaoViewModel)
        {
            var fornecedorRegiao = Mapper.Map<FornecedorRegiao>(fornecedorRegiaoViewModel);
            var fornecedorRegiaoRetornada = fornecedorRegiaoService.Criar(fornecedorRegiao);

            return Mapper.Map<FornecedorRegiaoViewModel>(fornecedorRegiaoRetornada);
        }
        public void Deletar(int idFornecedorRegiaoViewModel)
        {
            fornecedorRegiaoService.Deletar(idFornecedorRegiaoViewModel);
        }

        public FornecedorRegiaoViewModel BuscarPorId(int idFornecedorRegiao)
        {
            return Mapper.Map<FornecedorRegiaoViewModel>(fornecedorRegiaoService.BuscarPorId(idFornecedorRegiao));
        }
        public IEnumerable<FornecedorRegiaoViewModel> BuscarTodos()
        {
            return Mapper.Map<IEnumerable<FornecedorRegiaoViewModel>>(fornecedorRegiaoService.BuscarTodos());
        }

        public void Dispose()
        {
            fornecedorRegiaoService.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
