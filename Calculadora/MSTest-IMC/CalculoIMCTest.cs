using Calculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTest_IMC
{
    [TestClass]
    public class CalculoIMCTest
    {
        [TestMethod]
        public void calcularIMC()
        {
            //preparação
            double peso = 110;
            double altura = 1.79; 

            //ação
            var resultadoIMC = operacoes.calcularIMC(peso, altura);

            //verificação
            Assert.AreEqual(34.33, resultadoIMC);

        }
    }
}
