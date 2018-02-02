using RR.Distribuidora.Domain.Interfaces.Repositories;
using RR.Distribuidora.Domain.Interfaces.Services;
using RR.Distribuidora.Domain.Models;
using RR.Distribuidora.Domain.Validations.Regiao;
using System;
using System.Collections.Generic;

namespace RR.Distribuidora.Domain.Services
{
    public class RegiaoService : IRegiaoService
    {
        private readonly IRegiaoRepository regiaoRepository;

        public RegiaoService(IRegiaoRepository regiaoRepository)
        {
            this.regiaoRepository = regiaoRepository;
        }

        public Regiao Criar(Regiao regiao)
        {
            if (!regiao.IsValid())
                return regiao;

            regiao.ResultadoValidacao = new RegiaoConsistenteValidation().Validate(regiao);
            regiao.ResultadoValidacao = new RegiaoProntaParaRegistrarValidation(regiaoRepository).Validate(regiao);

            if (!regiao.ResultadoValidacao.IsValid)
                return regiao;

            return regiaoRepository.Criar(regiao);
        }
        public Regiao Atualizar(Regiao regiao)
        {
            if (!regiao.IsValid())
                return regiao;

            regiao.ResultadoValidacao = new RegiaoConsistenteValidation().Validate(regiao);
            regiao.ResultadoValidacao = new RegiaoProntaParaRegistrarValidation(regiaoRepository).Validate(regiao);

            return regiaoRepository.Atualizar(regiao);
        }

        public Regiao BuscarPorId(int idRegiao)
        {
            return regiaoRepository.BuscarPorId(idRegiao);
        }
        public IEnumerable<Regiao> BuscarTodos()
        {
            return regiaoRepository.BuscarTodos();
        }

        public void Dispose()
        {
            regiaoRepository.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
