using System;
using Xunit;
using Desafio_Projeto___Bootcamp_WEX___Desenvolvimento_.NET_e_QA___Testes;

namespace Teste_Projeto_Bootcamp_WEX___Desenvolvimento_.NET_e_QA
{
    public class UnitTest1
    {
        //Teste Soma Simples
        [Fact]
        public void Test2()
        {
            Calculadora calc = new Calculadora();

            int resultado = calc.somar(1, 2);
            Assert.Equal(3, resultado);
        }

        // Teste Somar com várias possibilidades
        [Theory]
        [InlineData (1,2,3)]
        [InlineData (4,5,9)]
        [InlineData (3,2,5)]
        public void TestSomar(int num1, int num2, int resultado)
        {
            Calculadora calc = new Calculadora();

            int resultadoCalculadora = calc.subtrair(num1,num2);
            Assert.Equal(resultado, resultadoCalculadora);
        }

        // Teste Subtrair com várias possibilidades
        [Theory]
        [InlineData(3, 2, 1)]
        [InlineData(5, 2, 3)]
        [InlineData(8, 2, 6)]
        public void TestSubtrair(int num1, int num2, int resultado)
        {
            Calculadora calc = new Calculadora();

            int resultadoCalculadora = calc.subtrair(num1, num2);
            Assert.Equal(resultado, resultadoCalculadora);
        }

        // Teste Multiplicar com várias possibilidades
        [Theory]
        [InlineData(3, 2, 6)]
        [InlineData(5, 2, 10)]
        [InlineData(8, 2, 16)]
        public void TestMultiplicar(int num1, int num2, int resultado)
        {
            Calculadora calc = new Calculadora();

            int resultadoCalculadora = calc.multiplicar(num1, num2);
            Assert.Equal(resultado, resultadoCalculadora);
        }

        // Teste Dividir com várias possibilidades
        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(10, 2, 5)]
        [InlineData(9, 3, 3)]
        public void TestDividir(int num1, int num2, int resultado)
        {
            Calculadora calc = new Calculadora();

            int resultadoCalculadora = calc.dividir(num1, num2);
            Assert.Equal(resultado, resultadoCalculadora);
        }

        // Testa que verifica se o número é divisil por zero, retornando uma exception/error.
        [Fact]
        public void testarDivisaoPorZero()
        {
            Calculadora calc = new Calculadora();
            Assert.Throws<DivideByZeroException>(
                () => calc.dividir(3, 0));
        }

        // Teste que verifica se a lista do histórico está vazia (NotEmpty) e verifica se a contagem da lista é igual a 3.
        [Fact]
        public void testarHistorico()
        {
            Calculadora calc = new Calculadora();

            calc.somar(1, 2);
            calc.somar(3, 5);
            calc.somar(4, 7);
            calc.somar(8, 6);

            var lista = calc.historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);

        }


    }
}
