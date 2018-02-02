using RR.Distribuidora.Domain.Interfaces.Repositories;
using RR.Distribuidora.Domain.Interfaces.Services;
using RR.Distribuidora.Domain.Models;
using System;
using System.Collections.Generic;

namespace RR.Distribuidora.Domain.Services
{
    public class EstadoService : IEstadoService
    {
        private readonly IEstadoRepository estadoRepository;

        public EstadoService(IEstadoRepository estadoRepository)
        {
            this.estadoRepository = estadoRepository;
        }

        public Estado BuscarPorId(int idEstado)
        {
            return estadoRepository.BuscarPorId(idEstado);
        }
        public IEnumerable<Estado> BuscarTodos()
        {
            return estadoRepository.BuscarTodos();
        }

        public void Dispose()
        {
            estadoRepository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
