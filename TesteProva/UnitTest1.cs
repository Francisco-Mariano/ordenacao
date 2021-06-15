using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ordena;

namespace TesteProva
{
    [TestClass]
    public class TesteTurma1
    {
        /// <summary>
        /// Função de apoio que verifica se um vetor está ordenado
        /// </summary>
        private bool EstaOrdenado(int[] v)
        {
            for (int i = 0; i < v.Length - 1; i++)
            {
                if (v[i] > v[i + 1]) return false;
            }
            return true;
        }

        /// <summary>
        /// Teste simples que ordena um vetor usando o Quicksort e CONTA O NÚMERO DE TROCAS REALIZADO. 
        /// Lembrando que trocar um número com ele mesmo não conta como troca. 
        /// </summary>
        [TestMethod]
        public void P2_QuantasTrocasSimples()
        {
            // Preparando o vetor para ordenar
            int[] dados = { 9, 8, 2, 3, 4, 5, 6, 7, 0, 1 };
            Ordenar ord = new Ordenar();
            int a = ord.QuickSortOrder(dados);
            Assert.AreEqual(3, a);
            Assert.AreEqual(true, EstaOrdenado(dados));
        }

        /// <summary>
        /// Teste simples que ordena um vetor usando o Quicksort e CONTA O NÚMERO DE TROCAS REALIZADO. 
        /// Lembrando que trocar um número com ele mesmo não conta como troca. 
        /// </summary>
        [TestMethod]
        public void P3_QuantasTrocasComplicado()
        {
            // Preparando o vetor para ordenar
            int[] dados = new int[10000000];

            for (int i = 0; i < 100; i++)
                dados[i] = i;
            for (int i = 100; i < dados.Length - 100; i++)
                dados[10000000 - i - 1 - 100] = i;

            Ordenar ord = new Ordenar();
            int a = ord.QuickSortOrder(dados);
            Assert.AreEqual(5000000, a);
            Assert.AreEqual(true, EstaOrdenado(dados));
        }

        /// <summary>
        /// Este teste de desempenho tem um limite de execução de 5s, usando o quicksort em 10 milhões de elementos. 
        /// Em um i7 o quicksort tradicional rodou, sem otimização, em 8 segundos
        /// Após a otimização, rodou em 5 segundos
        /// </summary>
        [TestMethod, Timeout(5000)]
        public void P5_OrdenacaoVelozFuriosa()
        {
            // Preparando o vetor para ordenar
            int[] dados = new int[100000000];

            for (int i = 0; i < 100; i++)
                dados[i] = i;
            for (int i = 100; i < dados.Length - 100; i++)
                dados[100000000 - i - 1 - 100] = i;

            Ordenar ord = new Ordenar();
            int a = ord.QuickSortOrderNinja(dados);
            Assert.AreEqual(50000000, a);
            Assert.AreEqual(true, EstaOrdenado(dados));
        }

    }
}