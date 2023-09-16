global using Xunit;
using Projeto_teste_operacoes;

namespace TestXUnit
{
    public class UnitTest1
    {
        [Fact]
        public void SomarDoisNumeros()
        {
            //Arranje: Preparação

            double pNum = 1;

            double sNum = 1;

            double rNum = 2;

            //Act: Ação

            var resultado = operacoes.Somar(pNum, sNum);

            //Assert: Verificação


            Assert.Equal(rNum, resultado);

        }
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(3, 3, 6)]
        [InlineData(7, 7, 14)]
        [InlineData(3, 2, 5)]

        public void SomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            //Act: Ação

            var resultado = operacoes.Somar(pNum, sNum);

            //Assert: Verificação

            Assert.Equal(rNum, resultado);
        }
    }

}