using Microsoft.VisualStudio.TestTools.UnitTesting;
using RR.Distribuidora.Domain.Models;
using RR.Distribuidora.Domain.Specifications.Regiao;

namespace RR.Distribuidora.Domain.UnitTest.Specifications.Regioes
{
    [TestClass]
    public class RegiaoDeveConterDescricaoSpecificationTest
    {
        #region Satisfatorio
        [TestMethod]
        public void Regiao_DeveConterDescricao_Especificacao_Satisfatorio()
        {
            // Arrange
            var regiao = new Regiao { Descricao = "Região Central." };

            // Action
            var especificacao = new RegiaoDeveConterDescricaoSpecification().IsSatisfiedBy(regiao);

            // Assert
            Assert.IsTrue(especificacao);
        }
        #endregion

        #region NaoSatisfatorio
        [TestMethod]
        public void Regiao_DeveConterDescricao_Especificacao_NaoSatisfatorio()
        {
            // Arrange
            var regiao = new Regiao { Descricao = "" };

            // Action
            var especificacao = new RegiaoDeveConterDescricaoSpecification().IsSatisfiedBy(regiao);

            // Assert
            Assert.IsFalse(especificacao);
        }
        #endregion
    }
}
