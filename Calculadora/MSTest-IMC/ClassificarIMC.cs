using Calculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTest_IMC
{
    [TestClass]
    public class ClassificarIMC
    {
        [TestMethod]    
        public void ClasssificarIMC() 
        {
            //arrange - preparação
            double imc = 28;

            //act - ação
            var calissificacaoIMC = operacoes.classificarIMC(imc);

            //assert - verificação
            Assert.AreEqual("Sobrepeso", calissificacaoIMC);
        }
    }
}
