using AutoMapper;
using RR.Distribuidora.Application.Interfaces;
using RR.Distribuidora.Application.ViewModels;
using RR.Distribuidora.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace RR.Distribuidora.Application.Services
{
    public class EstadoApplicationService : IEstadoApplicationService
    {
        private readonly IEstadoService estadoService;

        public EstadoApplicationService(IEstadoService estadoService)
        {
            this.estadoService = estadoService;
        }

        public EstadoViewModel BuscarPorId(int idEstado)
        {
            return Mapper.Map<EstadoViewModel>(estadoService.BuscarPorId(idEstado));
        }
        public IEnumerable<EstadoViewModel> BuscarTodos()
        {
            return Mapper.Map<IEnumerable<EstadoViewModel>>(estadoService.BuscarTodos());
        }

        public void Dispose()
        {
            estadoService.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
