using Calculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnitTest
{
    public class CalculadoraIMC
    {
        [Fact]
        public void CalcularIMC() 
        {
            //preparação
            double peso = 110;
            double altura = 1.79;

            //ação
            var resultado = operacoes.calcularIMC(peso, altura);

            //verificação
            Assert.Equal(34.33, resultado);
        }
        [Theory]
        [InlineData(80,1.79,24.97)]
        [InlineData(100, 1.79, 31.21)]
        
        public void CalcularIMC2(double peso, double altura, double ResultadoEsp)
        { 
            //ação
            var resultadoIMC = operacoes.calcularIMC(peso, altura);

            //verificação
            Assert.Equal(ResultadoEsp, resultadoIMC);
        }
    }
}
