using Microsoft.VisualStudio.TestTools.UnitTesting;
using RR.Distribuidora.Domain.Constants;
using RR.Distribuidora.Domain.Models;
using System.Linq;

namespace RR.Distribuidora.Domain.UnitTest.Models
{
    [TestClass]
    public class RegiaoTest
    {
        #region Valida
        [TestMethod]
        public void Regiao_AutoValidacao_Valida()
        {
            // Arrange
            var regiao = new Regiao
            {
                IdRegiao = 1,
                IdEstado = 2,
                Descricao = "Região Sudeste",
                Ativo = true
            };

            // Action
            var resultado = regiao.IsValid();

            // Assert
            Assert.IsTrue(resultado);
        }
        #endregion

        #region NaoValida
        [TestMethod]
        public void Regiao_AutoValidacao_NaoValida()
        {
            // Arrange
            var regiao = new Regiao
            {
                IdRegiao = 1,
                IdEstado = 0,
                Descricao = "",
                Ativo = true
            };

            // Action
            var resultado = regiao.IsValid();
            Assert.IsTrue(regiao.ResultadoValidacao.Erros.Any(e => e.Message == ValidationsConstants.RegiaoDeveConterDescricao));
            Assert.IsTrue(regiao.ResultadoValidacao.Erros.Any(e => e.Message == ValidationsConstants.RegiaoDeveConterIdEstado));

            // Assert
            Assert.IsFalse(resultado);
        }
        #endregion
    }
}
