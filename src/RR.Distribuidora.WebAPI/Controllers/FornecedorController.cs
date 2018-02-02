using RR.Distribuidora.Application.Interfaces;
using RR.Distribuidora.Application.ViewModels;
using System.Collections.Generic;
using System.Web.Http;

namespace RR.Distribuidora.WebAPI.Controllers
{
    [RoutePrefix("api/fornecedores")]
    public class FornecedorController : ApiController
    {
        private readonly IFornecedorApplicationService fornecedorApplicationService;

        public FornecedorController(IFornecedorApplicationService fornecedorApplicationService)
        {
            this.fornecedorApplicationService = fornecedorApplicationService;
        }

        [HttpGet]
        [Route("buscar/{idFornecedor}")]
        public FornecedorViewModel BuscarPorId(int idFornecedor)
        {
            return fornecedorApplicationService.BuscarPorId(idFornecedor);
        }

        [HttpGet]
        [Route("buscar")]
        public IEnumerable<FornecedorViewModel> BuscarTodos()
        {
            return fornecedorApplicationService.BuscarTodos();
        }
    }
}