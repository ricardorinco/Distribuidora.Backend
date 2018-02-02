using RR.Distribuidora.Application.Interfaces;
using RR.Distribuidora.Application.ViewModels;
using System.Collections.Generic;
using System.Web.Http;

namespace RR.Distribuidora.WebAPI.Controllers
{
    [RoutePrefix("api/atendimentos")]
    public class AtendimentoController : ApiController
    {
        private readonly IAtendimentoApplicationService atendimentoApplicationService;

        public AtendimentoController(IAtendimentoApplicationService atendimentoApplicationService)
        {
            this.atendimentoApplicationService = atendimentoApplicationService;
        }

        [HttpGet]
        [Route("buscar/{idFornecedorRegiao}")]
        public AtendimentoViewModel BuscarPorIdFornecedorRegiao(int idFornecedorRegiao)
        {
            return atendimentoApplicationService.BuscarPorId(idFornecedorRegiao);
        }

        [HttpGet]
        [Route("buscar")]
        public IEnumerable<AtendimentoViewModel> BuscarTodos()
        {
            return atendimentoApplicationService.BuscarTodos();
        }

        [HttpGet]
        [Route("buscar-por-fornecedor/{idFornecedor}")]
        public IEnumerable<AtendimentoViewModel> BuscarPorIdFornecedor(int idFornecedor)
        {
            return atendimentoApplicationService.BuscarPorIdFornecedor(idFornecedor);
        }
    }
}