using RR.Distribuidora.Application.Interfaces;
using RR.Distribuidora.Application.ViewModels;
using System.Collections.Generic;
using System.Web.Http;

namespace RR.Distribuidora.WebAPI.Controllers
{
    [RoutePrefix("api/fornecedores-regioes")]
    public class FornecedorRegiaoController : ApiController
    {
        private readonly IFornecedorRegiaoApplicationService fornecedorRegiaoApplicationService;

        public FornecedorRegiaoController(IFornecedorRegiaoApplicationService fornecedorRegiaoApplicationService)
        {
            this.fornecedorRegiaoApplicationService = fornecedorRegiaoApplicationService;
        }

        [HttpPost]
        [Route("criar")]
        public FornecedorRegiaoViewModel Criar(FornecedorRegiaoViewModel fornecedorRegiaoViewModel)
        {
            return fornecedorRegiaoApplicationService.Criar(fornecedorRegiaoViewModel);
        }

        [HttpDelete]
        [Route("deletar/{idFornecedorRegiao}")]
        public void Deletar(int idFornecedorRegiao)
        {
            fornecedorRegiaoApplicationService.Deletar(idFornecedorRegiao);
        }

        [HttpGet]
        [Route("buscar/{idFornecedorRegiao}")]
        public FornecedorRegiaoViewModel BuscarPorId(int idFornecedorRegiao)
        {
            return fornecedorRegiaoApplicationService.BuscarPorId(idFornecedorRegiao);
        }

        [HttpGet]
        [Route("buscar")]
        public IEnumerable<FornecedorRegiaoViewModel> BuscarTodos()
        {
            return fornecedorRegiaoApplicationService.BuscarTodos();
        }
    }
}