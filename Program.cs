using System;
using System.Collections.Generic;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criação da fila de operações
            Queue<Operacoes> filaOperacoes = new Queue<Operacoes>();

            // Adicionando operações à fila
            filaOperacoes.Enqueue(new Operacoes { valorA = 2, valorB = 3, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 14, valorB = 8, operador = '-' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 5, valorB = 6, operador = '*' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 2147483647, valorB = 2, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 18, valorB = 3, operador = '/' });

            // Instanciando a calculadora
            Calculadora calculadora = new Calculadora();

            // Pilha para armazenar os resultados
            Stack<long> resultados = new Stack<long>();

            // Loop para processar todas as operações na fila
            while (filaOperacoes.Count > 0)
            {
                // Retira a operação da fila
                Operacoes operacao = filaOperacoes.Dequeue();

                // Realiza o cálculo e atualiza a operação com o resultado
                operacao = calculadora.calcular(operacao);

                // Imprime o resultado da operação
                Console.WriteLine("{0} {1} {2} = {3}", operacao.valorA, operacao.operador, operacao.valorB, operacao.resultado);

                // Imprime as operações pendentes
                ImprimirOperacoesPendentes(filaOperacoes);

                // Armazena o resultado na pilha
                resultados.Push(operacao.resultado);
            }

            // Imprime todos os resultados armazenados na pilha
            Console.WriteLine("\nResultados calculados:");
            while (resultados.Count > 0)
            {
                Console.WriteLine(resultados.Pop());
            }
        }

        // Função para imprimir operações pendentes na fila
        static void ImprimirOperacoesPendentes(Queue<Operacoes> fila)
        {
            Console.WriteLine("\nOperações pendentes:");
            foreach (var op in fila)
            {
                Console.WriteLine("{0} {1} {2}", op.valorA, op.operador, op.valorB);
            }
        }
    }
}
