using AutoMapper;
using RR.Distribuidora.Application.Interfaces;
using RR.Distribuidora.Application.ViewModels;
using RR.Distribuidora.Domain.Interfaces.Services;
using RR.Distribuidora.Domain.Models;
using System;
using System.Collections.Generic;

namespace RR.Distribuidora.Application.Services
{
    public class RegiaoApplicationService : IRegiaoApplicationService
    {
        private readonly IRegiaoService regiaoService;

        public RegiaoApplicationService(IRegiaoService regiaoService)
        {
            this.regiaoService = regiaoService;
        }

        public RegiaoViewModel Criar(RegiaoViewModel regiaoViewModel)
        {
            var regiao = Mapper.Map<Regiao>(regiaoViewModel);
            var regiaoRetornada = regiaoService.Criar(regiao);

            return Mapper.Map<RegiaoViewModel>(regiaoRetornada);
        }
        public RegiaoViewModel Atualizar(RegiaoViewModel regiaoViewModel)
        {
            var regiao = Mapper.Map<Regiao>(regiaoViewModel);
            var regiaoRetornada = regiaoService.Atualizar(regiao);

            return Mapper.Map<RegiaoViewModel>(regiaoRetornada);
        }

        public RegiaoViewModel BuscarPorId(int idRegiao)
        {
            return Mapper.Map<RegiaoViewModel>(regiaoService.BuscarPorId(idRegiao));
        }
        public IEnumerable<RegiaoViewModel> BuscarTodos()
        {
            return Mapper.Map<IEnumerable<RegiaoViewModel>>(regiaoService.BuscarTodos());
        }

        public void Dispose()
        {
            regiaoService.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
