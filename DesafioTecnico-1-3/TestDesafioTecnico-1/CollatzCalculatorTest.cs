using System;
using DesafioTecnico_1.Collatz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestDesafioTecnico_1
{
    /// <summary>
    /// Classe de teste para a classe que faz o cálculo
    /// </summary>
    [TestClass]
    public class CollatzCalculatorTest
    {
        /// <summary>
        /// Testa com input de um valor negativo
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(Exception),
            "Não é possível calcular um número negativo")]
        public void TestNegativeNumberToCalculate()
        {
            CollatzCalculator.ResolveNumber(-1);
        }

        /// <summary>
        /// Testa se está calculando corretamente
        /// </summary>
        [TestMethod]
        public void TestResultOfResultNumberIsOk()
        {
            var number = CollatzCalculator.ResolveNumber(13);

            Assert.IsTrue(number == 10, "O valor está correto");
        }

    }
}