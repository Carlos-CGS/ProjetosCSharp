using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_Projeto___Bootcamp_WEX___Desenvolvimento_.NET_e_QA___Testes
{
    public class Calculadora
    {
        private List<String> listaHistorico;
        public Calculadora()
        {
            listaHistorico = new List<String>(); 
        }
        
        public int somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            //Abaixo: Faz-se a inserção deste resultado na lista.
            listaHistorico.Insert(0, "Resultado " + resultado);
            return resultado;
        }
        public int subtrair(int num1, int num2)
        {
            int resultado = num1 - num2;
            //Abaixo: Faz-se a inserção deste resultado na lista.
            listaHistorico.Insert(0, "Resultado " + resultado);
            return resultado;
        }
        public int multiplicar(int num1, int num2)
        {
            int resultado = num1 * num2;
            //Abaixo: Faz-se a inserção deste resultado na lista.
            listaHistorico.Insert(0, "Resultado " + resultado);
            return resultado;
        }
        public int dividir(int num1, int num2)
        {
            int resultado = num1 / num2;
            //Abaixo: Faz-se a inserção deste resultado na lista.
            listaHistorico.Insert(0, "Resultado " + resultado);
            return resultado;
        }

        public List<String> historico()
        {
            //Abaixo remove-se os itens da lista a partir da posição 3 até o count total da lista.
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico;
        }
    }
}
