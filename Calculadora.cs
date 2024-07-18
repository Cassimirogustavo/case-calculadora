using System;

namespace Calculadora
{
    public class Calculadora
    {
        // Método para calcular a operação especificada
        public Operacoes calcular(Operacoes operacao)
        {
            // Switch case para determinar o tipo de operação e chamar o método correspondente
            switch (operacao.operador)
            {
                case '+': operacao.resultado = soma(operacao); break;
                case '-': operacao.resultado = subtracao(operacao); break;
                case '*': operacao.resultado = multiplicacao(operacao); break;
                case '/': operacao.resultado = divisao(operacao); break; // Adicionado caso para divisão
                default: operacao.resultado = 0; break;
            }
            return operacao;
        }

        // Métodos para realizar as operações matemáticas
        public int soma(Operacoes operacao)
        {
            return operacao.valorA + operacao.valorB;
        }

        public int subtracao(Operacoes operacao)
        {
            return operacao.valorA - operacao.valorB;
        }

        public int multiplicacao(Operacoes operacao)
        {
            return operacao.valorA * operacao.valorB;
        }

        public decimal divisao(Operacoes operacao)
        {
            if (operacao.valorB != 0)
            {
                return (decimal)operacao.valorA / operacao.valorB;
            }
            else
            {
                throw new DivideByZeroException("Erro: Divisão por zero.");
            }
        }
    }
}
