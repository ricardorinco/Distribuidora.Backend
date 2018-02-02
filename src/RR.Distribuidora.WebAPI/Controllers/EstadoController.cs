using RR.Distribuidora.Application.Interfaces;
using RR.Distribuidora.Application.ViewModels;
using System.Collections.Generic;
using System.Web.Http;

namespace RR.Distribuidora.WebAPI.Controllers
{
    [RoutePrefix("api/estados")]
    public class EstadoController : ApiController
    {
        private readonly IEstadoApplicationService estadoApplicationService;

        public EstadoController(IEstadoApplicationService estadoApplicationService)
        {
            this.estadoApplicationService = estadoApplicationService;
        }

        [HttpGet]
        [Route("buscar/{idEstado}")]
        public EstadoViewModel BuscarPorId(int idEstado)
        {
            return estadoApplicationService.BuscarPorId(idEstado);
        }

        [HttpGet]
        [Route("buscar")]
        public IEnumerable<EstadoViewModel> BuscarTodos()
        {
            return estadoApplicationService.BuscarTodos();
        }
    }
}