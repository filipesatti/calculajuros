using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculadorJuros.Services;

namespace TestJuros
{
    [TestClass]
    public class TestJurosServic
    {
        [TestMethod]
        public void TestCalculoJuros()
        {
            var result = JurosService.CalculaJuros(100,5);
            Assert.AreEqual(105.10M, result);
        }

        [TestMethod]
        public void TestCalculoJurosCase2()
        {
            var result = JurosService.CalculaJuros(200, 12);
            Assert.AreEqual(225.37M, result);
        }

        [TestMethod]
        public void TestCalculoJurosCase3()
        {
            var result = JurosService.CalculaJuros(0, 12);
            Assert.AreEqual(0M, result);
        }

        [TestMethod]
        public void TestCalculoJurosCase4()
        {
            var result = JurosService.CalculaJuros(500, 0);
            Assert.AreEqual(500M, result);
        }
    }
}
