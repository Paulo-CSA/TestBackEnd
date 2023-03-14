using Calculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnitTest
{
    
    public class ClassificarIMC
    {
        [Fact]
        public void ClassificaIMC() 
        {
            //preparação
            double imc = 28;

            //ação
            var resultado = operacoes.classificarIMC(imc);

            //verificação
            Assert.Equal("Sobrepeso", resultado);

        }
        [Theory]
        [InlineData(28, "Sobrepeso")]
        [InlineData(31, "Obesidade Grau I")]
        public void classificaResultadoIMC(double imc, string resultadoEsperado)
        {
            //ação
            var resultado = operacoes.classificarIMC(imc);

            //verificação
            Assert.Equal(resultadoEsperado, resultado);
        }
        
    }
}
