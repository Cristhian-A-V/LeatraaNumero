using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumeroaLetra.Controllers;

namespace UnitTestNumeroaLetra
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestNumeroaLetra1()
        {
            //Arrange
            LiteralController literalController = new LiteralController();
            int numero = 15;
            string esperado = "QUINCE";
            //Act
            string resultado = literalController.Literalget(numero);
            //Assert
            Assert.AreEqual(esperado, resultado);
        }
    }
}
