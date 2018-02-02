using RR.Distribuidora.Application.Interfaces;
using RR.Distribuidora.Application.ViewModels;
using System.Collections.Generic;
using System.Web.Http;

namespace RR.Distribuidora.WebAPI.Controllers
{
    [RoutePrefix("api/regioes")]
    public class RegiaoController : ApiController
    {
        private readonly IRegiaoApplicationService regiaoApplicationService;

        public RegiaoController(IRegiaoApplicationService regiaoApplicationService)
        {
            this.regiaoApplicationService = regiaoApplicationService;
        }

        [HttpPost]
        [Route("criar")]
        public RegiaoViewModel Criar(RegiaoViewModel regiaoViewModel)
        {
            return regiaoApplicationService.Criar(regiaoViewModel); ;
        }

        [HttpPut]
        [Route("atualizar/{idRegiao}")]
        public RegiaoViewModel Atualizar(int idRegiao, RegiaoViewModel regiaoViewModel)
        {
            regiaoViewModel.IdRegiao = idRegiao;
            regiaoViewModel = regiaoApplicationService.Atualizar(regiaoViewModel);

            return regiaoViewModel;
        }

        [HttpGet]
        [Route("buscar/{idRegiao}")]
        public RegiaoViewModel BuscarTodos(int idRegiao)
        {
            return regiaoApplicationService.BuscarPorId(idRegiao);
        }

        [HttpGet]
        [Route("buscar")]
        public IEnumerable<RegiaoViewModel> BuscarTodos()
        {
            return regiaoApplicationService.BuscarTodos();
        }
    }
}