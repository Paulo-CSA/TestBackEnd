using Projeto_Teste;

namespace TestMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange - Preparação
            double pNum = 1;
            double sNum = 1;
            double rNum = 2;

            //act - ação
            var resultado = Operacoes.Somar(pNum, sNum);

            // assert - verificação
            Assert.AreEqual(rNum, resultado);
        }
        [DataTestMethod]
        [DataRow(1,1,2)]
        [DataRow(2, 2, 4)]
        [DataRow(2, 1, 2)]
        public void TestMethod2(double pNum,double sNum,double rNum)
        {
           
            //act - ação
            var resultado = Operacoes.Somar(pNum, sNum);

            // assert - verificação
            Assert.AreEqual(rNum, resultado);
        }
    }
}