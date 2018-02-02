using RR.Distribuidora.Application.Interfaces;
using RR.Distribuidora.Application.Services;
using RR.Distribuidora.Domain.Interfaces.Repositories;
using RR.Distribuidora.Domain.Interfaces.Services;
using RR.Distribuidora.Domain.Services;
using RR.Distribuidora.Infrastructure.Data.Repositories;
using SimpleInjector;

namespace RR.Distribuidora.Infrastructure.Data.CrossCutting
{
    public class BootStrapper
    {
        public static void Register(Container container)
        {
            // Application
            container.Register<IAtendimentoApplicationService, AtendimentoApplicationService>(Lifestyle.Scoped);
            container.Register<IEstadoApplicationService, EstadoApplicationService>(Lifestyle.Scoped);
            container.Register<IFornecedorRegiaoApplicationService, FornecedorRegiaoApplicationService>(Lifestyle.Scoped);
            container.Register<IFornecedorApplicationService, FornecedorApplicationService>(Lifestyle.Scoped);
            container.Register<IRegiaoApplicationService, RegiaoApplicationService>(Lifestyle.Scoped);

            // Domain
            container.Register<IAtendimentoService, AtendimentoService>(Lifestyle.Scoped);
            container.Register<IEstadoService, EstadoService>(Lifestyle.Scoped);
            container.Register<IFornecedorRegiaoService, FornecedorRegiaoService>(Lifestyle.Scoped);
            container.Register<IFornecedorService, FornecedorService>(Lifestyle.Scoped);
            container.Register<IRegiaoService, RegiaoService>(Lifestyle.Scoped);

            // Data
            container.Register<IAtendimentoRepository, AtendimentoRepository>(Lifestyle.Scoped);
            container.Register<IEstadoRepository, EstadoRepository>(Lifestyle.Scoped);
            container.Register<IFornecedorRegiaoRepository, FornecedorRegiaoRepository>(Lifestyle.Scoped);
            container.Register<IFornecedorRepository, FornecedorRepository>(Lifestyle.Scoped);
            container.Register<IRegiaoRepository, RegiaoRepository>(Lifestyle.Scoped);
        }
    }
}
