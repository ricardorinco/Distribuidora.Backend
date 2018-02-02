using Microsoft.VisualStudio.TestTools.UnitTesting;
using RR.Distribuidora.Domain.Models;
using RR.Distribuidora.Domain.Specifications.Regiao;

namespace RR.Distribuidora.Domain.UnitTest.Specifications.Regioes
{
    [TestClass]
    public class RegiaoDeveConterIdEstadoSpecificationTest
    {
        #region Satisfatorio
        [TestMethod]
        public void Regiao_DeveConterIdEstado_Especificacao_Satisfatorio()
        {
            // Arrange
            var regiao = new Regiao { IdEstado = 26 };

            // Action
            var especificacao = new RegiaoDeveConterIdEstadoSpecification().IsSatisfiedBy(regiao);

            // Assert
            Assert.IsTrue(especificacao);
        }
        #endregion

        #region NaoSatisfatorio
        [TestMethod]
        public void Regiao_DeveConterIdEstado_Especificacao_NaoSatisfatorio()
        {
            // Arrange
            var regiao = new Regiao { IdEstado = 0 };

            // Action
            var especificacao = new RegiaoDeveConterIdEstadoSpecification().IsSatisfiedBy(regiao);

            // Assert
            Assert.IsFalse(especificacao);
        }
        #endregion
    }
}
