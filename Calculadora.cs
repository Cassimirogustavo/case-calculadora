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
                case '/': operacao.resultado = divisao(operacao); break;
                default: operacao.resultado = 0; break;
            }
            return operacao;
        }

        // Métodos para realizar as operações matemáticas
        public long soma(Operacoes operacao)
        {
            return operacao.valorA + operacao.valorB;
        }

        public long subtracao(Operacoes operacao)
        {
            return operacao.valorA - operacao.valorB;
        }

        public long multiplicacao(Operacoes operacao)
        {
            return operacao.valorA * operacao.valorB;
        }

        public long divisao(Operacoes operacao)
        {
            if (operacao.valorB != 0)
            {
                // Conversão explícita de decimal para long
                return (long)(operacao.valorA / operacao.valorB);
            }
            else
            {
                throw new DivideByZeroException("Erro: Divisão por zero.");
            }
        }
    }
}
