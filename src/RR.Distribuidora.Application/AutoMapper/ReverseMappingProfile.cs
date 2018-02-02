using AutoMapper;
using RR.Distribuidora.Application.ViewModels;
using RR.Distribuidora.Domain.Models;

namespace RR.Distribuidora.Application.AutoMapper
{
    public class ReverseMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<Atendimento, AtendimentoViewModel>().ReverseMap();
            CreateMap<Estado, EstadoViewModel>().ReverseMap();
            CreateMap<FornecedorRegiao, FornecedorRegiaoViewModel>().ReverseMap();
            CreateMap<Fornecedor, FornecedorViewModel>().ReverseMap();
            CreateMap<Regiao, RegiaoViewModel>().ReverseMap();
        }
    }
}
