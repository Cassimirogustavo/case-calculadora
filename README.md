Este repositório contém uma implementação básica de uma calculadora em C#, desenvolvida como parte de um estudo de caso para Engenharia de Software JR.

## Funcionalidades Implementadas

- **Adição**: Operações de soma (`+`).
- **Subtração**: Operações de subtração (`-`).
- **Multiplicação**: Operações de multiplicação (`*`).
- **Divisão**: Implementada a operação de divisão (`/`), com tratamento para divisão por zero.

## Problemas Corrigidos

- Corrigido o problema de processar apenas o primeiro item da fila infinitamente.
- Implementada a funcionalidade de divisão.
- Corrigido o cálculo da penúltima operação.
- Adicionada a funcionalidade para imprimir toda a lista de operações a serem processadas após cada cálculo realizado.
- Criada uma pilha para salvar o resultado de cada cálculo concluído e imprimir a pilha ao final.

## Estrutura do Código

### Program.cs

Contém a função principal que define as operações a serem realizadas e controla o fluxo principal da aplicação. Utiliza uma fila para armazenar e processar as operações e uma instância da classe `Calculadora` para executar os cálculos.

### Calculadora.cs

Define a lógica para realizar operações matemáticas básicas (`soma`, `subtracao`, `multiplicacao`, `divisao`). Cada operação é tratada de acordo com o operador especificado (`+`, `-`, `*`, `/`).

### Operacoes.cs

Define a estrutura de dados `Operacoes` para armazenar cada operação matemática, incluindo os valores dos operandos, o operador e o resultado da operação.

## Como Usar

1. Clone o repositório.
2. Abra o projeto em um ambiente de desenvolvimento como Visual Studio.
3. Execute o projeto para ver a calculadora em ação.
