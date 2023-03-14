using Projeto_Teste;

namespace TestXUnit
{
    public class UnitTest1
    {
        [Fact]
        public void SomarDoisNumeros()
        {
            //arrange - prepara��o
            double pNum = 1;
            double sNum = 1;
            double rNum = 2;

            //action - a��o

            var resultado = Operacoes.Somar(pNum, sNum);

            //assert - verifica��o

            Assert.Equal(rNum, resultado);

        }
        [Theory]
        [InlineData(1,1,2)]
        [InlineData(2,2,4)]
        [InlineData(2,1,2)]
        public void SomarLista(double pNum, double sNum, double rNum)
        {

            //act - a��o
            var resultado = Operacoes.Somar(pNum, sNum);

            // assert - verifica��o
            Assert.Equal(rNum, resultado);
        }
    }
}